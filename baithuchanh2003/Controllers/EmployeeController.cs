using Microsoft.AspNetCore.Mvc;
using baithuchanh2003.Modles;

namespace baithuchanh2003.Controllers;

    public class EmployeeController : Controller
{
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Employee eml)
    {
        string ketqua = eml.ID + "+" + eml.FullName + "+" + eml.Address + "+" + eml.PhoneNumber;
        ViewBag.abc = ketqua;
        return View();
    
    }
}
