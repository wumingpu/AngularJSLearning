using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTELearning.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Layout()
        {
            return View();
        }
        // GET: Home
        public ActionResult Index(bool full)
        {
            if (full)
            {
                return View();
            }
            else if (full)
            {
                return PartialView();
            }
            else
            {
                return View();
            }
        }

        public ActionResult FirstPage()
        {
            return PartialView();
        }

        public ActionResult SecondPage()
        {
            return View();
        }
    }
}