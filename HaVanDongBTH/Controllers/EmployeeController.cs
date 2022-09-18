using System.Collections.Specialized;
using Microsoft.AspNetCore.Mvc;
using HaVanDongBTH.Models;
namespace HaVanDongBTH.Controllers;
public class EmployeeController : Controller 
{
public ActionResult Index()
 {
    List<Employee> StdList= new List<Employee>
    { 
        new Employee { EmployeeID = 1, EmployeeName = "Cuong", Age = 16 },
        new Employee { EmployeeID = 2, EmployeeName = "Hieu", Age = 17 },
        new Employee { EmployeeID = 3, EmployeeName = "Hung", Age = 18 },
    };
     ViewData["Employee"] = StdList;
        return View();
  }
  [HttpGet]
public IActionResult Create()
{
    return View();
}
[HttpPost]
public IActionResult Create(Employee std)
{
   ViewBag.thongtinNhanVien = std.EmployeeID+ "-" + std.EmployeeName+ "-" + std.Age;
    return View();
}
}