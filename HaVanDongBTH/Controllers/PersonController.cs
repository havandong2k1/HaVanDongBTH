using System.Collections.Specialized;
using Microsoft.AspNetCore.Mvc;
using HaVanDongBTH.Models;
namespace HaVanDongBTH.Controllers
{
   public class PersonController : Controller
   {
     public ActionResult Index()
     {
        List<Person> StdList= new List<Person>
        { 
            new Person { Age = 18, Address = "HaNoi", PhoneNumber = "0124215144" },
            new Person { Age = 18, Address = "HaNoi", PhoneNumber = "0821414412" },
            new Person { Age = 18, Address = "HaNoi", PhoneNumber = "0214124412" },
        };
         ViewBag.ThongtinSV = StdList.Count();
            return View();
     }
     [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Person std)
    {
       ViewBag.thongtin = std.Age + "-" + std.Address + "-" + std.PhoneNumber;
        return View();
    }
   }
}