using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P2log.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Test()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
