using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP.Models;

namespace ERP.Controllers
{
    public class TowaryController : Controller
    {
        private AplikacjeInternetoweEntities1 db = new AplikacjeInternetoweEntities1();

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
        public ActionResult Create(TowaryViewModel model)
        {
            try
            {
                AplikacjeInternetoweEntities1 db = new AplikacjeInternetoweEntities1();
                Towary towar = new Towary();

                towar.nazwa = model.nazwa;
                towar.kod = model.kod;
                towar.netto = model.netto;
                towar.vat = model.vat;
                towar.brutto = model.brutto;
                towar.opis = model.opis;

                db.Towary.Add(towar);
                db.SaveChanges();

                return View("TowarDodany");
            }
            catch
            {
                return View("TowarNiedodany");
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