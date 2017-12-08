using NWCustomer.DAL;
using NWCustomer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NWCustomer.Controllers
{
    public class HomeController : Controller
    {
        private PotentialsContext db = new PotentialsContext();
        public ActionResult Index()
        {
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

        public ActionResult RegisterConfirm(PotentialsViewModel model)
        {
            return View(model);
        }

        public ActionResult Tests()
        {
            return View();
        }
    }
}