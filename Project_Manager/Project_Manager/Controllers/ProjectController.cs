using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Manager.Models;
namespace Project_Manager.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Show_All_Project()//查询所有的项目
        {
            List<Project> ls = Project_Mgr.ShowAllProject();
            return View(ls);
        }
        //[HttpPost]
        //public ActionResult Add_Per_Data(string )
        //{
              


        //}

    }
}