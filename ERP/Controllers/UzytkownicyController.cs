using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP.Models;
using PagedList;

namespace ERP.Controllers
{
    public class UzytkownicyController : Controller
    {
        public ActionResult Index()//Index(int? page)
        {
            AplikacjeInternetoweEntities1 db = new AplikacjeInternetoweEntities1();

            List<Uzytkownicy> uzytkownicyList = new List<Uzytkownicy>();
            uzytkownicyList = db.Uzytkownicy.ToList();

            //Uzytkownicy uzytkownik = db.Uzytkownicy.SingleOrDefault(x => x.id == id);
            List<UserViewModel> vmList = new List<UserViewModel>();

            foreach (var x in uzytkownicyList)
            {
                UserViewModel vm = new UserViewModel();

                vm.id = x.id;
                vm.haslo = x.haslo;
                vm.nazwa = x.nazwa;
                vm.rola = x.rola;
                vm.ulica = x.ulica;

                vmList.Add(vm);
            }

            //int pageSize = 3;
           // int pageNumber = (page ?? 1);
            ViewBag.Uzytkownicy = vmList;
            //return View(vmList.ToPagedList(pageNumber, pageSize));
            return View();
        }


        public ActionResult Login()
        {
            if (Session["username"] != null)
            {
                return RedirectToAction("Index", "Home", new { username = Session["username"].ToString() });
            }
            else {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Login(UserViewModel model)
        {
            AplikacjeInternetoweEntities1 db = new AplikacjeInternetoweEntities1();

            var userLoggedIn = db.Uzytkownicy.SingleOrDefault(x => x.nazwa == model.nazwa && x.haslo == model.haslo);


   
            if (userLoggedIn != null)
            {
                ViewBag.message = "Logged In";
                ViewBag.triedOnce = "true";
                ViewBag.username = model.nazwa;

                Session["username"] = model.nazwa;

                return View("LoggedIn");
            }
            else
            {
                return View("LoginFailed");
            }

            //if (model.UserName == "xyz" && model.Password == "xyz")
            //{
            //    Session["uname"] = model.UserName;
            //    Session.Timeout = 10;
            //    return RedirectToAction("Index");
            //}

            
        }

        [HttpGet]
        public ActionResult Edit(long UserId)
        {
            AplikacjeInternetoweEntities1 db = new AplikacjeInternetoweEntities1();

           // UserViewModel userModel = new UserViewModel();

            var userModel = db.Uzytkownicy.SingleOrDefault(x => x.id == UserId);
            UserViewModel uViewModel = new UserViewModel();


            if (userModel != null) {
                uViewModel.id = userModel.id;
                uViewModel.nazwa = userModel.nazwa;
                uViewModel.haslo = userModel.haslo;
                uViewModel.kodpocz = userModel.kodpocz;
                uViewModel.miejscowosc = userModel.miejscowosc;
                uViewModel.rola = userModel.rola;

            }
            ViewBag.Uzytkownik = uViewModel;
            return View("Edit");
        }



        [HttpPost]
        public JsonResult UserDelete(long UserId)
        {
            AplikacjeInternetoweEntities1 db = new AplikacjeInternetoweEntities1();

            bool result = false;

            Uzytkownicy user = db.Uzytkownicy.SingleOrDefault(x => x.id == UserId);

            if (user != null) {
                try
                {
                    db.Uzytkownicy.Remove(user);
                    db.SaveChanges();
                    result = true;
                }
                catch (Exception e)
                {
                    e.ToString();
                }
            }

            return Json(result, JsonRequestBehavior.AllowGet);

        }
    }
}