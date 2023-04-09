using Microsoft.AspNetCore.Mvc;
using BaiThucHanh2703.Models;
using BaiThucHanh2703.Data;
using Microsoft.EntityFrameworkCore;

namespace BaiThucHanh2703.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController (ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _context.Employees.ToListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Employee eml)
        {
            if(ModelState.IsValid)
            {
                _context.Add(eml);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(eml);
        } 
    }
}