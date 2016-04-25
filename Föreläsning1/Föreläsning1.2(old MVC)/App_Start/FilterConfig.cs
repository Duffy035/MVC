using System.Web;
using System.Web.Mvc;

namespace Föreläsning1._2_old_MVC_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
