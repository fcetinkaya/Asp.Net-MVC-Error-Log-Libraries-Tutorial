using System.Web;
using System.Web.Mvc;

namespace AspMVC_WebErrorLog.Log4net
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
