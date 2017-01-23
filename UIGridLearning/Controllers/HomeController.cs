using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UIGridLearning.Models;

namespace UIGridLearning.Controllers
{
    public class HomeController : Controller
    {
        public static string Lang = "zh-cn";
        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult UIGridBasic()
        {
            Models.Home.Lang = "zh-cn";
            return View();
        }

        public ActionResult ProductIntroduce()
        {
            return View();
        }

        public ActionResult LangTest()
        {
            return View();
        }

        public ActionResult AngularTranTest()
        {
            return View();
        }
    }
}