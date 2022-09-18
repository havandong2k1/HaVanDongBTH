using System.Collections.Specialized;
using Microsoft.AspNetCore.Mvc;
using HaVanDongBTH.Models;
namespace HaVanDongBTH.Controllers
{
   public class StudentController : Controller
   {
    // GET: Student
    public ActionResult Index()
    {
        List<Student> StdList= new List<Student>
        { 
            new Student { StudentID = 1, StudentName = "Nguyen Van A", Age = 18 },
            new Student { StudentID = 2, StudentName = "Nguyen Van B", Age = 22 },
            new Student { StudentID = 3, StudentName = "Nguyen Van C", Age = 33 },
            new Student { StudentID = 4, StudentName = "Nguyen Van D", Age = 20 },
            new Student { StudentID = 5, StudentName = "Nguyen Van E", Age = 34 },
            new Student { StudentID = 6, StudentName = "Nguyen Van F", Age = 53 },
            new Student { StudentID = 7, StudentName = "Nguyen Van G", Age = 19 },
        };
        ViewData["Student"] = StdList;
            return View();
        

    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Student std)
    {
       ViewBag.Sinhvien = std.StudentID + "-" + std.StudentName + "-" + std.Age;
        return View();
    }

    }
}