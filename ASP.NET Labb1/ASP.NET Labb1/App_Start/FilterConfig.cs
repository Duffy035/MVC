﻿using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Labb1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}