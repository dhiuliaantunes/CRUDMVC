using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OurWebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dates()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Filmes()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}