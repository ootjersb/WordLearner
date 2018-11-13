using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WordLearnerMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "WordLearner is a tool to help you memorize words when learning a new language.";

            return View();
        }

        public ActionResult Contact()
        {
            throw new NotImplementedException();
            //ViewBag.Message = "Your contact page.";

            //return View();
        }
    }
}