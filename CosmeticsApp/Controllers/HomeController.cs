using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CosmeticsApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Perfume()
        {
            ViewBag.Message = "Your perfume products are here";

            return View();
        }

        public ActionResult Profile()
        {
            ViewBag.Message = "Your profile products are here";

            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Message = "your makeup prods are here";

            return View();
        }

    }
}