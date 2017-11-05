using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_Mgr.CustomFilter
{
    public class Filter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //base.OnActionExecuting(filterContext);
            try
            {
                var sess = filterContext.RequestContext.HttpContext.Session["username"];
                if (sess == null)
                    filterContext.Result = new RedirectResult("/Account/Login");
            }
            catch
            {
                filterContext.Result = new RedirectResult("/Shared/Error");
            }
        }

        //当方法执行完毕
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }
    }
}