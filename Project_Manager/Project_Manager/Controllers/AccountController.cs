using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Manager.Models;
namespace Project_Manager.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CheckLogIn(string username,string password)
        {

            if(User_Mgr.Check_Login(username,password) == true)
           // if (username != null || password != null)
            {
                Session["username"] = username;//记录用户名
                Session["user_id"] = User_Mgr.getID(username);//记录用户的id
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
            else
            {
                return Content("<script>alert('用户名或者密码出错!');window.location.href='../Account/LogIn';</script>");
            }

        }



        public ActionResult Index()
        {
            return View();
        }
    }
}