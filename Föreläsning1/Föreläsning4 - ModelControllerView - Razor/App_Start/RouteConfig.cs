using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Föreläsning4___ModelControllerView___Razor
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "KungFu",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "KungFu", action = "FullDetails", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "Beer",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Beer", action = "List", id = UrlParameter.Optional }
        );

            routes.MapRoute(
                name: "Recipe",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Recipe", action = "FullDetails", id = UrlParameter.Optional }
            );
        }
    }
}
