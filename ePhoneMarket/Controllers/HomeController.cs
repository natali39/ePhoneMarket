using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ePhoneMarket.Models;

namespace ePhoneMarket.Controllers
{
    public class HomeController : Controller
    {
        PhoneContext phoneContext = new PhoneContext();

        public ActionResult Index()
        {
            IEnumerable<Phone> phones = phoneContext.Phones;

            ViewBag.Phones = phones;

            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.Id = id;

            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.DateTime = GetTodayDate();

            phoneContext.Purchases.Add(purchase);
            phoneContext.SaveChanges();

            return $"Уважаемый {purchase.Name}, с вами скоро свяжутся!";
        }

        [HttpGet]
        public ActionResult GetPurchases()
        {
            IEnumerable<Purchase> purchases = phoneContext.Purchases;

            ViewBag.Purchases = purchases;

            return View();
        }

        private DateTime GetTodayDate()
        {
            return DateTime.Now;
        }

        //[HttpGet]
        //public ActionResult SomeMethod()
        //{
        //    ViewData["Date"] = DateTime.Now;

        //    return View("/Views/Home/MyView.cshtml");
        //}
    }
}