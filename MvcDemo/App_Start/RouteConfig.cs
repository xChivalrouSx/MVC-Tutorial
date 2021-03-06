﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "StudentDetailsRoute",
                url: "Student/Details",
                defaults: new { controller = "Student", action = "Index" }
            );

            routes.MapRoute(
                name: "StudentEditRoute",
                url: "Student/Edit",
                defaults: new { controller = "Student", action = "Index" }
            );

            routes.MapRoute(
                name: "StudentDeleteRoute",
                url: "Student/Delete",
                defaults: new { controller = "Student", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
