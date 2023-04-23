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
    public class StudentController : Controller
    {
        private readonly MvcMovieContext _context;

        public StudentController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: Student
        public async Task<IActionResult> Index()
        {
            var mvcMovieContext = _context.Student.Include(s => s.Address).Include(s => s.Faculty).Include(s => s.Sex);
            return View(await mvcMovieContext.ToListAsync());
        }

        // GET: Student/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .Include(s => s.Address)
                .Include(s => s.Faculty)
                .Include(s => s.Sex)
                .FirstOrDefaultAsync(m => m.StudentID == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Student/Create
        public IActionResult Create()
        {
            ViewData["AddressID"] = new SelectList(_context.Address, "AddressID", "AddressID");
            ViewData["FacultyID"] = new SelectList(_context.Set<Faculty>(), "FacultyID", "FacultyID");
            ViewData["SexID"] = new SelectList(_context.Sex, "SexID", "SexID");
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentID,StudentName,SexID,AddressID,FacultyID")] Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AddressID"] = new SelectList(_context.Address, "AddressID", "AddressID", student.AddressID);
            ViewData["FacultyID"] = new SelectList(_context.Set<Faculty>(), "FacultyID", "FacultyID", student.FacultyID);
            ViewData["SexID"] = new SelectList(_context.Sex, "SexID", "SexID", student.SexID);
            return View(student);
        }

        // GET: Student/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            ViewData["AddressID"] = new SelectList(_context.Address, "AddressID", "AddressID", student.AddressID);
            ViewData["FacultyID"] = new SelectList(_context.Set<Faculty>(), "FacultyID", "FacultyID", student.FacultyID);
            ViewData["SexID"] = new SelectList(_context.Sex, "SexID", "SexID", student.SexID);
            return View(student);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StudentID,StudentName,SexID,AddressID,FacultyID")] Student student)
        {
            if (id != student.StudentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.StudentID))
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
            ViewData["AddressID"] = new SelectList(_context.Address, "AddressID", "AddressID", student.AddressID);
            ViewData["FacultyID"] = new SelectList(_context.Set<Faculty>(), "FacultyID", "FacultyID", student.FacultyID);
            ViewData["SexID"] = new SelectList(_context.Sex, "SexID", "SexID", student.SexID);
            return View(student);
        }

        // GET: Student/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .Include(s => s.Address)
                .Include(s => s.Faculty)
                .Include(s => s.Sex)
                .FirstOrDefaultAsync(m => m.StudentID == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Student == null)
            {
                return Problem("Entity set 'MvcMovieContext.Student'  is null.");
            }
            var student = await _context.Student.FindAsync(id);
            if (student != null)
            {
                _context.Student.Remove(student);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(string id)
        {
          return (_context.Student?.Any(e => e.StudentID == id)).GetValueOrDefault();
        }
    }
}
