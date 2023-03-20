using Microsoft.AspNetCore.Mvc;

namespace baitapthuchanh0703.Controllers
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
        public IActionResult Bachai()
    {
        return View();
           
    }
        [HttpPost]
        public IActionResult Bachai(string hesoA,string hesoB,string hesoC)
    {
            
            double delta, x1, x2, a=0,b=0,c=0;
            string ketqua;
            if(!String.IsNullOrEmpty(hesoA)) a = Convert.ToDouble(hesoA);
            if(!String.IsNullOrEmpty(hesoB)) a = Convert.ToDouble(hesoB);//Convert chuyen doi sang kieu todouble
            if(!String.IsNullOrEmpty(hesoC)) a = Convert.ToDouble(hesoC);
            if(a==0) ketqua = "Khong phai phuong trinh bac 2";
            else
            {
                delta = Math.Pow(b,2) - 4 * a * c;
                if(delta<0) ketqua ="Phuong trinh vo nghiem";
                else if(delta ==0)
                {
                    x1 = -b/(2*a);
                    ketqua ="Phuong trinh co nghiem kep  = " + x1;
                }
                else
                {
                    x1 = (-b +  Math.Sqrt(delta))/(2*a);
                    x2 = (-b +  Math.Sqrt(delta))/(2*a);
                    ketqua = "Phuong trinh co 2 hai nghiem phaan biet: X1= " + x1 +  ", X2 = "+ x2;
                }
            }
            ViewBag.abc =ketqua;
            return View();
        }
    }
    
}