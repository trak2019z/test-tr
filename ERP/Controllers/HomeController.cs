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
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult WyswietlUzytkownikow()
        {
            AplikacjeInternetoweEntities1 db = new AplikacjeInternetoweEntities1();

            List<Uzytkownicy> uzytkownicyList = new List<Uzytkownicy>();
            uzytkownicyList = db.Uzytkownicy.ToList();

            //Uzytkownicy uzytkownik = db.Uzytkownicy.SingleOrDefault(x => x.id == id);
            List<UserViewModel> vmList = new List<UserViewModel>();

            foreach (var x in uzytkownicyList)
            {
                UserViewModel vm = new UserViewModel();

                vm.haslo = x.haslo;
                vm.nazwa = x.nazwa;
                vm.rola = x.rola;
                vm.ulica = x.ulica;

                vmList.Add(vm);
            }
            return View(vmList);
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