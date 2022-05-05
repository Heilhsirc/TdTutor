using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TdTutor.Models;

namespace TdTutor.Controllers
{
    public class RectoresController : Controller
    {
        private readonly TdTutorDataContext _context;

        public RectoresController(TdTutorDataContext context)
        {
            _context = context;
        }

        // GET: Rectores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Rector.ToListAsync());
        }

        // GET: Rectores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rector = await _context.Rector
                .FirstOrDefaultAsync(m => m.id == id);
            if (rector == null)
            {
                return NotFound();
            }

            return View(rector);
        }

        // GET: Rectores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rectores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nombre")] Rector rector)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rector);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rector);
        }

        // GET: Rectores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rector = await _context.Rector.FindAsync(id);
            if (rector == null)
            {
                return NotFound();
            }
            return View(rector);
        }

        // POST: Rectores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nombre")] Rector rector)
        {
            if (id != rector.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rector);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RectorExists(rector.id))
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
            return View(rector);
        }

        // GET: Rectores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rector = await _context.Rector
                .FirstOrDefaultAsync(m => m.id == id);
            if (rector == null)
            {
                return NotFound();
            }

            return View(rector);
        }

        // POST: Rectores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rector = await _context.Rector.FindAsync(id);
            _context.Rector.Remove(rector);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RectorExists(int id)
        {
            return _context.Rector.Any(e => e.id == id);
        }
    }
}
