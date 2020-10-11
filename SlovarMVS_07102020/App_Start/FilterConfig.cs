using System.Web;
using System.Web.Mvc;

namespace SlovarMVS_07102020
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
