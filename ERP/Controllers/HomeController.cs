using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP.Models;

namespace ERP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["username"] != null)
            {
                //AplikacjeInternetoweEntities1 db = new AplikacjeInternetoweEntities1();
                return View("IndexFull");
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Rejestracja()
        {
            return View();
        }

        public ActionResult Towary()
        {
            return View("Towary");
        }
    }
}