using System.Web;
using System.Web.Mvc;

namespace SimpleLogix_MultiTenantApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
