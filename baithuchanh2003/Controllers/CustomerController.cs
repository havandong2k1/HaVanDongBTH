using baithuchanh2003.Data;
using baithuchanh2003.Modles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace baithuchanh2003.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CustomerController (ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _context.Customers.ToListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Customer cus)
        {
            if(ModelState.IsValid)
            {
                _context.Add(cus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cus);
        } 
    }
}