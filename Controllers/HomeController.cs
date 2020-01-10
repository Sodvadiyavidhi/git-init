using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Message = "This content comes from the Controller.";
            ViewBag.Message = "This content comes from the view.";
            ViewData["FromController"] = "This is from the controller.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            


            return View();
        }
        public ActionResult Services()
        {
            ViewBag.Message = "We offer lots of great services.";



            return View();
        }
    }
}