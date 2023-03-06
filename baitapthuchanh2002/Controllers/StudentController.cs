using Microsoft.AspNetCore.Mvc;

namespace baitapthuchanh2002.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Index(string FullName)
        {
           string strReturn = "Hello" + FullName;
            ViewBag.abc = strReturn;
            return View();
        }
    }
    
}