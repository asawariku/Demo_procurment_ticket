using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RampUp.Controllers
{

    //Server change
    //Lock applied
    //change2
    //change1
    //change3
    //shelving
    //shelving 2
    //Suspend and Resume
    //change 4
    //merging
    //merging 2
    //merging 3
    //merging 4
    public class HomeController : Controller
    {
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
    }
}