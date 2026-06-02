using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentManager.Data;
using TournamentManager.Helpers;
using TournamentManager.Models;

namespace TournamentManager.Controllers
{
    public class PartidoController : Controller
    {
        private readonly TournamentDbContext _context;

        public PartidoController(TournamentDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int pageNumber = 1)
        {
            int pageSize = 9; // número de partidos por página

            var query = _context.Partidos
                .Include(p => p.Ronda).ThenInclude(r => r.Torneo)
                .Include(p => p.Equipos).ThenInclude(e => e.Equipo)
                .AsNoTracking();

            // Usamos el pageNumber recibido
            var partidos = await PaginatedList<Partido>.CreateAsync(query, pageNumber, pageSize);
            return View(partidos);
        }



        // GET: Partido/Details/5
        // En tu Controller:
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var partido = await _context.Partidos
                .Include(p => p.Ronda)
                    .ThenInclude(r => r!.Torneo) 
                .Include(p => p.Equipos)
                    .ThenInclude(ep => ep.Equipo)
                        .ThenInclude(e => e!.Jugadores)
                            .ThenInclude(j => j.HistorialPartidos)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (partido == null) return NotFound();

            return View(partido);
        }

        // GET: Partido/Create
        public IActionResult Create()
        {
            ViewData["RondaId"] = new SelectList(_context.Rondas, "Id", "Nombre");
            return View();
        }

        // POST: Partido/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RondaId")] Partido partido)
        {
            if (ModelState.IsValid)
            {
                _context.Add(partido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RondaId"] = new SelectList(_context.Rondas, "Id", "Nombre", partido.RondaId);
            return View(partido);
        }

        // GET: Partido/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partido = await _context.Partidos.FindAsync(id);
            if (partido == null)
            {
                return NotFound();
            }
            ViewData["RondaId"] = new SelectList(_context.Rondas, "Id", "Nombre", partido.RondaId);
            return View(partido);
        }

        // POST: Partido/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RondaId")] Partido partido)
        {
            if (id != partido.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(partido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PartidoExists(partido.Id))
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
            ViewData["RondaId"] = new SelectList(_context.Rondas, "Id", "Nombre", partido.RondaId);
            return View(partido);
        }

        // GET: Partido/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partido = await _context.Partidos
                .Include(p => p.Ronda)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (partido == null)
            {
                return NotFound();
            }

            return View(partido);
        }

        // POST: Partido/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var partido = await _context.Partidos.FindAsync(id);
            if (partido != null)
            {
                _context.Partidos.Remove(partido);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PartidoExists(int id)
        {
            return _context.Partidos.Any(e => e.Id == id);
        }
    }
}
