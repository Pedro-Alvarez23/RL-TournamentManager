using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TournamentManager.Data;
using TournamentManager.Helpers;
using TournamentManager.Models;
using TournamentManager.ViewModels;

namespace TournamentManager.Controllers
{
    public class RankingsController : Controller
    {
        private readonly TournamentDbContext _context;

        public RankingsController(TournamentDbContext context)
        {
            _context = context;
        }

        // GET: Rankings/Equipos
        public async Task<IActionResult> Equipos(int? pageNumber)
        {
            int pageSize = 8;

            // 1. TRAER DATOS (SQL): Traemos todos los equipos y sus partidos a memoria
            // Usamos ToListAsync() AQUÍ para cerrar la conexión con la base de datos
            var equiposRaw = await _context.Equipos
                .Include(e => e.Partidos)
                .AsNoTracking()
                .ToListAsync();

            // 2. PROCESAR (MEMORIA): Ahora C# ya puede leer tu propiedad 'Ganador'
            var rankingVM = equiposRaw.Select(e => new EquipoRankingVM
            {
                Equipo = e,
                GolesFavor = e.Partidos.Sum(ep => ep.Goles),
                // Aquí SÍ funciona tu lógica C# porque los datos ya están en RAM
                Victorias = e.PartidosGanados
            })
            .OrderByDescending(vm => vm.Victorias)
            .ThenByDescending(vm => vm.GolesFavor)
            .ToList();

            // 3. PAGINAR: Usamos el método Create (síncrono) que acabamos de crear
            var paginatedModel = PaginatedList<EquipoRankingVM>.Create(rankingVM, pageNumber ?? 1, pageSize);

            return View(paginatedModel);
        }

        // GET: Rankings/Jugadores
        public async Task<IActionResult> Jugadores(string sortOrder, int? pageNumber, string searchString)
        {
            int pageSize = 9;

            ViewData["CurrentSort"] = sortOrder;
            // Guardamos la búsqueda para que no se pierda al cambiar de página
            ViewData["CurrentFilter"] = searchString;

            ViewData["GolesSort"] = String.IsNullOrEmpty(sortOrder) ? "goles_asc" : "";
            ViewData["WinsSort"] = sortOrder == "wins" ? "wins_desc" : "wins";
            ViewData["MvpSort"] = sortOrder == "mvp" ? "mvp_desc" : "mvp";

            var jugadores = from j in _context.Jugadores.Include(j => j.Equipo)
                            select j;

            // Buscador
            if (!String.IsNullOrEmpty(searchString))
            {
                // Filtramos por Nick o Nombre (ignorando mayúsculas/minúsculas)
                jugadores = jugadores.Where(s => s.Nick!.Contains(searchString)
                                              || s.Nombre!.Contains(searchString));
                // Si buscas, reseteamos a la página 1 para que no te quedes en una página vacía
            }
            
            switch (sortOrder)
            {
                case "goles_asc": jugadores = jugadores.OrderBy(j => j.GolesTotales); break;
                case "wins": jugadores = jugadores.OrderByDescending(j => j.PartidosGanados); break;
                case "wins_desc": jugadores = jugadores.OrderBy(j => j.PartidosGanados); break;
                case "mvp": jugadores = jugadores.OrderByDescending(j => j.MVPsTotales); break;
                case "mvp_desc": jugadores = jugadores.OrderBy(j => j.MVPsTotales); break;
                default: jugadores = jugadores.OrderByDescending(j => j.GolesTotales); break;
            }

            return View(await PaginatedList<Jugador>.CreateAsync(jugadores.AsNoTracking(), pageNumber ?? 1, pageSize));
        }
    }
}