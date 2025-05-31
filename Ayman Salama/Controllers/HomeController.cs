using Ayman_Salama.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml.Linq;

namespace Ayman_Salama.Controllers
{
    public class HomeController : Controller
    {
        public static List<SendMesaage> MMM = new List<SendMesaage>();
        public static int lastid= 0;


        

        // public IActionResult Index() => View();

        public IActionResult Index()
        {
            ViewBag.MainTitle = HomeContent.MainTitle;
            ViewBag.MainDesc = HomeContent.MainDesc;
            return View();
        }



        [HttpPost]
        public IActionResult SendMessage(string name,string email,string message)
        {
            lastid++;

            MMM.Add(new SendMesaage {
                Id=lastid,

                Name = name,
                Email = email,
                Subject = message,
                Date = DateTime.Now

            });
          
             return RedirectToAction("contact");
        }






        [HttpGet]

        public IActionResult contact()
        {
            //ViewBag.Name = SendMesaage.Name;
            //ViewBag.Email = SendMesaage.Email;
            //ViewBag.Subject = SendMesaage.Subject;
            //ViewBag.Date = SendMesaage.Date;

            return View(MMM);
        }




        public IActionResult About() => View();
            public IActionResult Skills() => View();
            public IActionResult Projects() => View();
            public IActionResult Goals() => View();
        

        public IActionResult Login() => View();
            public IActionResult register() => View();
            public IActionResult projectdetails() => View();

       

      


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
