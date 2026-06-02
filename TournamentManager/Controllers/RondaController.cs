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
    public class RondaController : Controller
    {
        private readonly TournamentDbContext _context;

        public RondaController(TournamentDbContext context)
        {
            _context = context;
        }

        // GET: Ronda
        public async Task<IActionResult> Index()
        {
            var tournamentDbContext = _context.Rondas.Include(r => r.Torneo);
            return View(await tournamentDbContext.ToListAsync());
        }

        // GET: Ronda/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ronda = await _context.Rondas
                .Include(r => r.Torneo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ronda == null)
            {
                return NotFound();
            }

            return View(ronda);
        }

        // GET: Ronda/Create
        public IActionResult Create()
        {
            ViewData["TorneoId"] = new SelectList(_context.Torneos, "Id", "Nombre");
            return View();
        }

        // POST: Ronda/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,TorneoId")] Ronda ronda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ronda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TorneoId"] = new SelectList(_context.Torneos, "Id", "Nombre", ronda.TorneoId);
            return View(ronda);
        }

        // GET: Ronda/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ronda = await _context.Rondas.FindAsync(id);
            if (ronda == null)
            {
                return NotFound();
            }
            ViewData["TorneoId"] = new SelectList(_context.Torneos, "Id", "Nombre", ronda.TorneoId);
            return View(ronda);
        }

        // POST: Ronda/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,TorneoId")] Ronda ronda)
        {
            if (id != ronda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ronda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RondaExists(ronda.Id))
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
            ViewData["TorneoId"] = new SelectList(_context.Torneos, "Id", "Nombre", ronda.TorneoId);
            return View(ronda);
        }

        // GET: Ronda/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ronda = await _context.Rondas
                .Include(r => r.Torneo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ronda == null)
            {
                return NotFound();
            }

            return View(ronda);
        }

        // POST: Ronda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ronda = await _context.Rondas.FindAsync(id);
            if (ronda != null)
            {
                _context.Rondas.Remove(ronda);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RondaExists(int id)
        {
            return _context.Rondas.Any(e => e.Id == id);
        }
    }
}
