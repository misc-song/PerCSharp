using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Mgr.CustomFilter;
namespace Project_Mgr.Controllers
{
    public class HomeController : Controller
    {
        [Project_Mgr.CustomFilter.Filter]
        public ActionResult Index()
        {
            return View();
        }
        [Project_Mgr.CustomFilter.Filter]
        public ActionResult Main()
        {
            return View();
        }
        [Project_Mgr.CustomFilter.Filter]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Project_Mgr.CustomFilter.Filter]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Project_Mgr.CustomFilter.Filter]
        public ActionResult Left()
        {
            return View();
        }
        [Project_Mgr.CustomFilter.Filter]
        public ActionResult Center()
        {
            return View();
        }
        [Project_Mgr.CustomFilter.Filter]
        public ActionResult Top()
        {
            return View();
        }
    }
}