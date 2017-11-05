using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Manager.Models
{
    public class User_Mgr
    {
        public static bool  Check_Login(string username,string password)//检查登陆
        {
            Project_MgrEntities db = new Project_MgrEntities();
            User u = db.Users.Where(a => a.User_Name == username).FirstOrDefault();
           // User pwd = db.Users.Where(p => p.User_Pwd == password).FirstOrDefault();
            if(u.User_Name == username && u.User_Pwd == password )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int getID(string username)//获取当前用户的ID
        {
            Project_MgrEntities db = new Project_MgrEntities();
            User u = db.Users.Where(a => a.User_Name == username).FirstOrDefault();
            return u.User_Id;
        }
    }
}