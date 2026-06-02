using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TournamentManager.Data;
using TournamentManager.Models;

namespace TournamentManager.Controllers
{
    public class TorneoController : Controller
    {
        private readonly TournamentDbContext _context;

        public TorneoController(TournamentDbContext context)
        {
            _context = context;
        }

        // GET: Torneo
        public async Task<IActionResult> Index()
        {
            var tournamentDbContext = _context.Torneos.Include(t => t.Campeon).Include(t => t.MVP);
            return View(await tournamentDbContext.ToListAsync());
        }


        public IActionResult Details(int id)
        {
            var torneo = _context.Torneos
                .Include(t => t.Rondas)
                    .ThenInclude(r => r.Partidos)
                        .ThenInclude(p => p.Equipos)
                            .ThenInclude(ep => ep.Equipo)
                                .ThenInclude(e => e.Jugadores)
                .Include(t => t.MVP)
                .FirstOrDefault(t => t.Id == id);

            return View(torneo);
        }


        // GET: Torneo/Create
        public IActionResult Create()
        {
            ViewData["CampeonId"] = new SelectList(_context.Equipos, "Id", "Nombre");
            ViewData["MVPId"] = new SelectList(_context.Jugadores, "Id", "Nick");
            return View();
        }

        // POST: Torneo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,FechaInicio,FechaFin,Estado,CampeonId,MVPId")] Torneo torneo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(torneo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CampeonId"] = new SelectList(_context.Equipos, "Id", "Nombre", torneo.CampeonId);
            ViewData["MVPId"] = new SelectList(_context.Jugadores, "Id", "Nick", torneo.MVPId);
            return View(torneo);
        }

        // GET: Torneo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var torneo = await _context.Torneos.FindAsync(id);
            if (torneo == null)
            {
                return NotFound();
            }

            // LÓGICA FILTRADO DE JUGADORES (MVP)
            // Solo cargamos la lista si el torneo ha terminado y hay un campeón definido.
            if (torneo.Estado == EstadoTorneo.Finalizado && torneo.CampeonId.HasValue)
            {
                // Buscamos solo los jugadores que pertenecen al equipo campeón
                var jugadoresCampeon = _context.Jugadores
                                               .Where(j => j.EquipoId == torneo.CampeonId);

                ViewData["MVPId"] = new SelectList(jugadoresCampeon, "Id", "Nick", torneo.MVPId);
            }
            else
            {
                // Si no está finalizado, pasamos una lista vacía para evitar errores, 
                // aunque el campo estará oculto en la vista.
                ViewData["MVPId"] = new SelectList(new List<Jugador>(), "Id", "Nick");
            }

            // Nota: Ya no necesitamos ViewData["CampeonId"] porque en la vista es un input hidden.

            return View(torneo);
        }

        // POST: Torneo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,FechaInicio,FechaFin,Estado,CampeonId,MVPId")] Torneo torneo)
        {
            if (id != torneo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(torneo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TorneoExists(torneo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            // --- SI FALLA LA VALIDACIÓN, REPETIMOS LA LÓGICA DEL GET ---

            if (torneo.Estado == EstadoTorneo.Finalizado && torneo.CampeonId.HasValue)
            {
                var jugadoresCampeon = _context.Jugadores
                                               .Where(j => j.EquipoId == torneo.CampeonId);
                ViewData["MVPId"] = new SelectList(jugadoresCampeon, "Id", "Nick", torneo.MVPId);
            }
            else
            {
                ViewData["MVPId"] = new SelectList(new List<Jugador>(), "Id", "Nick");
            }

            return View(torneo);
        }

        // GET: Torneo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var torneo = await _context.Torneos
                .Include(t => t.Campeon)
                .Include(t => t.MVP)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (torneo == null)
            {
                return NotFound();
            }

            return View(torneo);
        }

        // POST: Torneo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var torneo = await _context.Torneos.FindAsync(id);
            if (torneo != null)
            {
                _context.Torneos.Remove(torneo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TorneoExists(int id)
        {
            return _context.Torneos.Any(e => e.Id == id);
        }
    }
}
