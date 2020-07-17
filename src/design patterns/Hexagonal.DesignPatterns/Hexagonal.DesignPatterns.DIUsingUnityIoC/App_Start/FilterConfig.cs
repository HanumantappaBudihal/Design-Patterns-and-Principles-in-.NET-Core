using System.Web;
using System.Web.Mvc;

namespace Hexagonal.DesignPatterns.DIUsingUnityIoC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
