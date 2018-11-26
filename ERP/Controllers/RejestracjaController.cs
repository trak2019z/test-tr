using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP.Models;

namespace ERP.Controllers
{
    public class RejestracjaController : Controller
    {
        // GET: Rejestracja
        public ActionResult Index()
        {
            return View();
        }

        // GET: Rejestracja/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rejestracja/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rejestracja/Create
        [HttpPost]
        public ActionResult Create(UserViewModel model)
        {
            try
            {
                AplikacjeInternetoweEntities1 db = new AplikacjeInternetoweEntities1();
                Uzytkownicy uzytkownik = new Uzytkownicy();

                uzytkownik.nazwa = model.nazwa;
                uzytkownik.haslo = model.haslo;
                uzytkownik.ulica = model.ulica;
                uzytkownik.kodpocz = model.kodpocz;
                uzytkownik.miejscowosc = model.miejscowosc;
                uzytkownik.rola = "uzytkownik";
                uzytkownik.nip = model.nip;

                db.Uzytkownicy.Add(uzytkownik);
                db.SaveChanges();

                return View("RejestracjaDone");
            }
            catch
            {
                return View("RejestracjaFailed");
            }
        }

        // GET: Rejestracja/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Rejestracja/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rejestracja/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rejestracja/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
