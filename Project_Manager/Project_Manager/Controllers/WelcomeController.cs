using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_Manager.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: Welcome
        public ActionResult WelcomePage()
        {
            return View();
        }
    }
}