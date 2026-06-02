using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TournamentManager.Data;
using TournamentManager.Models;
using TournamentManager.ViewModels;

namespace TournamentManager.Controllers
{
    public class TorneoWizardController : Controller
    {
        private readonly TournamentDbContext _context;

        public TorneoWizardController(TournamentDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Crear()
        {
            ViewBag.Equipos = await _context.Equipos.ToListAsync();
            return View(new CrearTorneoVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(CrearTorneoVM vm)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Equipos = await _context.Equipos.ToListAsync();
                return View(vm);
            }

            // Recolectamos los IDs de los 8 equipos
            var equiposId = new int?[]
            {
        vm.QF1, vm.QF2, vm.QF3, vm.QF4,
        vm.QF5, vm.QF6, vm.QF7, vm.QF8
            };

            //Verificamos que TODOS los equipos estén seleccionados ---
            if (equiposId.Any(e => !e.HasValue))
            {
                ViewBag.ErrorMessage = "You must select all teams before creating the tournament.";
                ViewBag.Equipos = await _context.Equipos.ToListAsync();
                return View(vm);
            }

            // Validamos duplicados
            if (equiposId.Distinct().Count() != equiposId.Length)
            {
                ViewBag.ErrorMessage = "Each team can only be selected once.";
                ViewBag.Equipos = await _context.Equipos.ToListAsync();
                return View(vm);
            }

            // Iniciamos la transacción para asegurar la integridad de datos
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    // Crear el Torneo
                    var torneo = new Torneo
                    {
                        Nombre = vm.Nombre,
                        FechaInicio = vm.FechaInicio,
                        Estado = EstadoTorneo.EnCurso
                    };
                    _context.Torneos.Add(torneo);
                    await _context.SaveChangesAsync(); // Guardamos para generar el ID del torneo

                    // Registrar participación de los equipos
                    foreach (var eqId in equiposId.Distinct())
                    {
                        _context.EquipoTorneos.Add(new EquipoTorneo
                        {
                            EquipoId = eqId!.Value,
                            TorneoId = torneo.Id,
                            Estado = EstadoParticipacion.EnCompeticion
                        });
                    }
                    await _context.SaveChangesAsync();

                    // Crear la ronda de Cuartos de Final
                    var rondaQF = new Ronda
                    {
                        TorneoId = torneo.Id,
                        Nombre = "Cuartos de final"
                    };
                    _context.Rondas.Add(rondaQF);
                    await _context.SaveChangesAsync();

                    // Generar los 4 partidos y sus enfrentamientos
                    for (int i = 0; i < 4; i++)
                    {
                        var partido = new Partido
                        {
                            RondaId = rondaQF.Id,
                            Jugado = false
                        };
                        _context.Partidos.Add(partido);
                        await _context.SaveChangesAsync();

                        // Asignar los dos equipos al partido
                        _context.EquipoPartidos.AddRange(
                            new EquipoPartido { EquipoId = equiposId[i * 2]!.Value, PartidoId = partido.Id, Goles = 0 },
                            new EquipoPartido { EquipoId = equiposId[i * 2 + 1]!.Value, PartidoId = partido.Id, Goles = 0 }
                        );
                    }

                    // Semifinales
                    var rondaSF = new Ronda { TorneoId = torneo.Id, Nombre = "Semifinales" };
                    _context.Rondas.Add(rondaSF);
                    _context.SaveChanges();

                    for (int i = 0; i < 2; i++)
                    {
                        _context.Partidos.Add(new Partido { RondaId = rondaSF.Id });
                    }
                    _context.SaveChanges();

                    // Final
                    var rondaFinal = new Ronda { TorneoId = torneo.Id, Nombre = "Final" };
                    _context.Rondas.Add(rondaFinal);
                    _context.SaveChanges();

                    _context.Partidos.Add(new Partido { RondaId = rondaFinal.Id });
                    _context.SaveChanges();

                    // Guardado final de los enfrentamientos (EquipoPartido)
                    await _context.SaveChangesAsync();

                    // Confirmamos la transacción
                    await transaction.CommitAsync();

                    return RedirectToAction("Details", "Torneo", new { id = torneo.Id });
                }
                catch (Exception)
                {
                    await transaction.RollbackAsync();

                    ViewBag.ErrorMessage = "An error occurred while creating the tournament. Please try again.";
                    ViewBag.Equipos = await _context.Equipos.ToListAsync();
                    return View(vm);
                }
            }
        }

    }
}