using Microsoft.AspNetCore.Mvc;

namespace baitapthuchanh2002.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
             return View();
        }
         public IActionResult About()
        {
             return View();
        }
    }
}