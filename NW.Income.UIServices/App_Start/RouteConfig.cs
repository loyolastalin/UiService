using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NW.Income.UIServices
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "DynamicContentApplication",
                url: "Dynamic/{applicationId}",
                defaults: new { controller = "Income", action = "DynamicContentApplication", applicationId = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Income", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
