using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using baithuchanh1704.Models;

namespace baithuchanh1704.Controllers
{
    public class SexController : Controller
    {
        private readonly MvcMovieContext _context;

        public SexController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: Sex
        public async Task<IActionResult> Index()
        {
              return _context.Sex != null ? 
                          View(await _context.Sex.ToListAsync()) :
                          Problem("Entity set 'MvcMovieContext.Sex'  is null.");
        }

        // GET: Sex/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Sex == null)
            {
                return NotFound();
            }

            var sex = await _context.Sex
                .FirstOrDefaultAsync(m => m.SexID == id);
            if (sex == null)
            {
                return NotFound();
            }

            return View(sex);
        }

        // GET: Sex/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sex/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SexID,SexName")] Sex sex)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sex);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sex);
        }

        // GET: Sex/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Sex == null)
            {
                return NotFound();
            }

            var sex = await _context.Sex.FindAsync(id);
            if (sex == null)
            {
                return NotFound();
            }
            return View(sex);
        }

        // POST: Sex/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("SexID,SexName")] Sex sex)
        {
            if (id != sex.SexID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sex);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SexExists(sex.SexID))
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
            return View(sex);
        }

        // GET: Sex/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Sex == null)
            {
                return NotFound();
            }

            var sex = await _context.Sex
                .FirstOrDefaultAsync(m => m.SexID == id);
            if (sex == null)
            {
                return NotFound();
            }

            return View(sex);
        }

        // POST: Sex/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Sex == null)
            {
                return Problem("Entity set 'MvcMovieContext.Sex'  is null.");
            }
            var sex = await _context.Sex.FindAsync(id);
            if (sex != null)
            {
                _context.Sex.Remove(sex);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SexExists(string id)
        {
          return (_context.Sex?.Any(e => e.SexID == id)).GetValueOrDefault();
        }
    }
}
