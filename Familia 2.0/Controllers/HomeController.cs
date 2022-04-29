using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Familia_2._0.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Despre aplicatia noastra.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Ne poti contacta!";

            return View();
        }
    }
}