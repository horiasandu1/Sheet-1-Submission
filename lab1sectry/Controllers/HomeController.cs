using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab1sectry.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Semester5()
        {
            return View();
        }

        public ActionResult Testimonials()
        {
            return View();
        }
    }
}