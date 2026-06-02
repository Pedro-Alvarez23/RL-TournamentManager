using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TournamentManager.Data;
using TournamentManager.Models;

namespace TournamentManager.Controllers
{
    public class MatchesController : Controller
    {
        private readonly TournamentDbContext _context;
        public MatchesController(TournamentDbContext ctx) => _context = ctx;

        // GET: Play
        public IActionResult Play(int id)
        {
            var partido = _context.Partidos
                .Include(p => p.Equipos).ThenInclude(e => e.Equipo).ThenInclude(eq => eq.Jugadores)
                .Include(p => p.Equipos).ThenInclude(ep => ep.EstadisticasJugadores)
                .First(p => p.Id == id);

            return View(partido);
        }

        // POST: Play
        [HttpPost]
        public IActionResult Play(int id, IFormCollection form)
        {
            var partido = _context.Partidos?
                .Include(p => p.Equipos)?.ThenInclude(ep => ep.Equipo).ThenInclude(e => e.Jugadores)
                .Include(p => p.Equipos)?.ThenInclude(ep => ep.EstadisticasJugadores)
                .Include(p => p.Ronda)?.ThenInclude(r => r.Torneo)?.ThenInclude(t => t.Equipos).ThenInclude(et => et.Equipo)
                .Include(p => p.Ronda).ThenInclude(r => r.Torneo).ThenInclude(t => t.Rondas).ThenInclude(r => r.Partidos)
                .First(p => p.Id == id);

            if (partido.Jugado)
                return RedirectToAction("Play", new { id });

            // LIMPIAR estadísticas anteriores (evita bugs EF)
            foreach (var ep in partido.Equipos)
            {
                var antiguas = _context.PartidoJugadores.Where(pj => pj.EquipoPartidoId == ep.Id).ToList();
                _context.PartidoJugadores.RemoveRange(antiguas);
                ep.EstadisticasJugadores.Clear();
            }

            // Calcular estadísticas
            foreach (var ep in partido.Equipos)
            {
                int totalGolesEquipo = 0;

                foreach (var j in ep.Equipo!.Jugadores)
                {
                    int g = int.Parse(form["g_" + j.Id]);
                    int a = int.Parse(form["a_" + j.Id]);
                    int s = int.Parse(form["s_" + j.Id]);

                    totalGolesEquipo += g;

                    // Acumulados jugador
                    j.GolesTotales += g;
                    j.AsistenciasTotales += a;
                    j.SalvadasTotales += s;
                    j.PartidosJugados++;

                    var stats = new PartidoJugador
                    {
                        JugadorId = j.Id,
                        EquipoPartidoId = ep.Id,
                        Goles = g,
                        Asistencias = a,
                        Salvadas = s,
                        Puntuacion = (g * 10) + (a * 5) + (s * 2)
                    };

                    _context.PartidoJugadores.Add(stats);
                    ep.EstadisticasJugadores.Add(stats);
                }

                ep.Goles = totalGolesEquipo;
            }

            // VALIDACIÓN: No puede haber más asistencias que goles
            foreach (var ep in partido.Equipos)
            {
                int totalGolesEquipo = ep.Goles; // ya calculados antes
                int totalAsistenciasEquipo = 0;

                foreach (var j in ep.Equipo!.Jugadores)
                {
                    int a = int.Parse(form["a_" + j.Id]); // tomamos directamente del formulario
                    totalAsistenciasEquipo += a;
                }

                if (totalAsistenciasEquipo > totalGolesEquipo)
                {
                    TempData["Error"] = $"El equipo {ep.Equipo!.Nombre} tiene más asistencias ({totalAsistenciasEquipo}) que goles ({totalGolesEquipo}). Ajusta los datos.";
                    return RedirectToAction("Play", new { id });
                }
            }

            // MVP
            var mvp = partido.Equipos
                .SelectMany(e => e.Equipo!.Jugadores)
                .OrderByDescending(j => int.Parse(form["g_" + j.Id]))
                .ThenByDescending(j => int.Parse(form["a_" + j.Id]))
                .First();

            partido.MVPJugadorId = mvp.Id;
            mvp.MVPsTotales++;

            // No empates
            if (partido.Equipos.First().Goles == partido.Equipos.Last().Goles)
            {
                TempData["Error"] = "There can be no tie";
                return RedirectToAction("Play", new { id });
            }

            partido.Jugado = true;

            var ganador = partido.Ganador!;
            var perdedor = partido.Perdedor!;

            ganador.PartidosJugados++;
            ganador.PartidosGanados++;
            ganador.GolesAFavor += partido.Equipos.First(e => e.EquipoId == ganador.Id).Goles;
            ganador.GolesEnContra += partido.Equipos.First(e => e.EquipoId == perdedor.Id).Goles;

            perdedor.PartidosJugados++;
            perdedor.GolesAFavor += partido.Equipos.First(e => e.EquipoId == perdedor.Id).Goles;
            perdedor.GolesEnContra += partido.Equipos.First(e => e.EquipoId == ganador.Id).Goles;

            foreach (var j in ganador.Jugadores) j.PartidosGanados++;

            avanzarGanador(partido);

            _context.SaveChanges();
            return RedirectToAction("Details", "Torneo", new { id = partido.Ronda!.TorneoId });
        }

        void avanzarGanador(Partido partido)
        {
            var torneo = partido.Ronda!.Torneo!;
            var rondas = torneo.Rondas.OrderBy(r => r.Id).ToList();
            int idxRonda = rondas.IndexOf(partido.Ronda!);
            var ganador = partido.Ganador!;

            if (idxRonda == rondas.Count - 1)
            {
                torneo.Estado = EstadoTorneo.Finalizado;
                torneo.CampeonId = ganador.Id;
                torneo.FechaFin = DateTime.Now;
                calcularMVP(torneo);
                return;
            }

            var partidosActuales = partido.Ronda.Partidos.OrderBy(p => p.Id).ToList();
            int idxPartido = partidosActuales.IndexOf(partido);
            var siguiente = rondas[idxRonda + 1];
            int destinoIndex = idxPartido / 2;

            var destino = siguiente.Partidos.OrderBy(p => p.Id).ElementAt(destinoIndex);
            destino.Equipos.Add(new EquipoPartido { EquipoId = ganador.Id });
        }

        void calcularMVP(Torneo torneo)
        {
            var equiposIds = torneo.Equipos!.Select(e => e.EquipoId).ToList();
            var mvp = _context.Jugadores.Where(j => equiposIds.Contains(j.EquipoId))
                                         .OrderByDescending(j => j.GolesTotales)
                                         .FirstOrDefault();

            if (mvp != null)
            {
                mvp.MVPsTotales++;
                torneo.MVPId = mvp.Id;
            }
        }
    }
}
