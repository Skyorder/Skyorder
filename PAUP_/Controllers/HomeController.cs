using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PAUP_.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Restorani()
        {
            return View();
        }


        public ActionResult Onama()
        {
            ViewBag.Message = "Aplikacija za brzu online narudžbu hrane na području Međimurske županije.";

            return View();
        }

        public ActionResult Kontakt()
        {
            
            ViewBag.Message = " Projekt izradili: ";

            return View();
        }
    }
}