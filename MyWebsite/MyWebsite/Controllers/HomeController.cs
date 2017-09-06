using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebsite.Controllers
{
    
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            string Name = Request.Form["Name"];
            string Email = Request.Form["Email"];
            string Message = Request.Form["Message"];
            if (Email != null) {
                TempData["Success"] = "Thanks for contacting will be get back to you soon";

            }

            return View();
        }

       

        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}