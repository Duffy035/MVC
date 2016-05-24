using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TestMedEntity__Globalasax.Models;

namespace TestMedEntity__Globalasax
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Tillagt själva
            using (var ctx = new SchoolContext())
            {
                Student student = new Student()
                {
                    StudentName = "Pelle"
                };

                ctx.Student.Add(student);
                ctx.SaveChanges();
            }
        }
    }
}
