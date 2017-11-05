using System.Web;
using System.Web.Mvc;

namespace Project_Mgr
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
           // filters.Add(new Project_Mgr.CustomFilter.Filter());
          // filters.Add(new System.Web.Mvc.AuthorizeAttribute());
        }
    }
}
