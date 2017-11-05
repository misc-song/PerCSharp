using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project_Manager.Models
{
    public class Project_Mgr
    {


        public static List<Project> ShowAllProject()//获取项目表中的内容
        {
            Project_MgrEntities db = new Project_MgrEntities();
            DbSet<Project> set = db.Set<Project>();

           // List<BlogMaster> list = set.SqlQuery("select *from BlogMaster where UserId='3'").ToList();

            List<Project> listAll = db.Database.SqlQuery<Project>("select *from Project").ToList();
            return listAll;
        }
        //public static bool Insert_Data()
        //{

        //}



    }
}