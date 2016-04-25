using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Föreläsning1._2_old_MVC_
{
    public class RouteConfig  //Styr inkommande HTTP requests, och mappar URL:er
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Vår egna för Images:
            routes.MapRoute(
                 name: "Images",
                 url: "Images/{action}/{id}",
                 defaults: new
                {
                    controller = "Images",
                    action = "TopTen",
                    id = UrlParameter.Optional
                }
              );


            //mysite.se
            //mysite.se/home
            //mysite.se/home/index
            //mysite.se/HoMe/inDex - samma resultat då det är case insensitive
            //mysite.se/home4/index - ger fel! Filen kommer inte hittas 


            //Detta är vår default:
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
