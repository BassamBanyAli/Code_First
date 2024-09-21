using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Code_First.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if(Session["IsLoginSuccessful"] != null && (bool)Session["IsLoginSuccessful"])
            {
                return View();
            }
            return RedirectToAction("Login","Users");

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
    }
}