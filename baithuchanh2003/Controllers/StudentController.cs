using Microsoft.AspNetCore.Mvc;
using baithuchanh2003.Models;

namespace baithuchanh2003.Controllers;

public class StudentController : Controller
{
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Student std)
    {
        string ketqua = std.StudentCode + "+" + std.FullName + "+" + std.Address;
        ViewBag.abc = ketqua;
        return View();
    
    }
}

