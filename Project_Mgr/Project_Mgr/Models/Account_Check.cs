using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Mgr.Models
{
    public class Account_Check
    {
        public static bool Check_Log_In(string username,string password)//验证登陆
        {
            Project_MgrEntities data_oper = new Project_MgrEntities();
            User UN = data_oper.Users.Where(a => a.User_Name == username).FirstOrDefault();
            User PW = data_oper.Users.Where(p => p.User_Pwd == password).FirstOrDefault();
            if(UN == null||PW == null)
            {
                return false;
            }
            if (UN.User_Name == username && PW.User_Pwd == password)
                return true;
            else
                return false;
        }
        public static int getID(string username)//获取用户ID
        {
            Project_MgrEntities data_oper = new Project_MgrEntities();
            User UN = data_oper.Users.Where(a => a.User_Name == username).FirstOrDefault();
            return UN.User_Id;
        }
        public static int getRole(string username)//获取用户Role
        {
            Project_MgrEntities data_oper = new Project_MgrEntities();
            User UN = data_oper.Users.Where(a => a.User_Name == username).FirstOrDefault();
            return (int)UN.Role;
        }
        public static User getUserInfo(string username)//获取用户的所有信息
        {
            Project_MgrEntities data_oper = new Project_MgrEntities();
            User UN = data_oper.Users.Where(a => a.User_Name == username).FirstOrDefault();
            return UN;
        }
    }
}