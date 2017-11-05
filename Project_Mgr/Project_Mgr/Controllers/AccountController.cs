using Project_Mgr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Project_Mgr.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CheckLogIn(string username, string password)//从view获取登陆名和密码
        {
            if ((username == "") || (password == ""))
            {
                return Content("<script>alert('用户名或密码为空!');window.location.href='../Home/LogIn';</script>");
            }

            if (Account_Check.Check_Log_In(username, password))//验证登陆
            {
                Session["username"] = username;//记录用户名
                Session["user_id"] = Account_Check.getID(username);//记录用户的id
                return RedirectToRoute(new { controller = "Home", action = "Main" });
            }
            else
            {
                //string str = string.Format("alert('{0}');", "弹出窗口");
                //return JavaScript(str); 
                //return JavaScript("alert('chucuo')");
                return Content("<script>alert('用户名或者密码出错!');window.location.href='../Home/LogIn';</script>");
            }
        }
        //// GET: Account
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: Account/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Account/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Account/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Account/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Account/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Account/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Account/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
