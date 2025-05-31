using Ayman_Salama.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ayman_Salama.Controllers
{
    public class DashboardController : Controller
    {


        //   public IActionResult dashboard()=> View();
        public IActionResult addproject() => View();
        public IActionResult edit_profile() => View();
        public IActionResult EditProject() => View();
        // public IActionResult messages()=> View();
        public IActionResult profile() => View();
        public IActionResult projectmanagement() => View();
        public IActionResult settings() => View();
       // public IActionResult viewMessage() => View();


        [HttpGet]
        public IActionResult dashboard()
        {
            ViewBag.Title = HomeContent.MainTitle;
            ViewBag.Description = HomeContent.MainDesc;
            return View();
        }

        [HttpPost]
        public IActionResult Edit(string title, string description)
        {
            HomeContent.MainTitle = title;
            HomeContent.MainDesc = description;

            // return RedirectToAction("Index", "Home");
            // بعد الحفظ، نرجع لنفس صفحة لوحة التحكم
            return RedirectToAction("Dashboard");
        }



        public IActionResult messages()
        {

            var MMM = HomeController.MMM; 
            // Assuming MMM is a static list in HomeController
            //MMM.
            //ViewBag.Name = MMM.Name;
            //ViewBag.Email = MMM.Email;
            //ViewBag.Subject = SendMesaage.Subject;
            //ViewBag.Date = SendMesaage.Date;
            //new List<SendMesaage>(MMM); // Convert to a new list if needed

            return View(MMM);
        }







        public IActionResult viewMessage(int id)
        {
            var message = HomeController.MMM.FirstOrDefault(m => m.Id == id);

            if (message == null)
            {
                return NotFound(); // أو View("Error") لو عندك صفحة خطأ
            }

            return View(message);
        }





    }
}
