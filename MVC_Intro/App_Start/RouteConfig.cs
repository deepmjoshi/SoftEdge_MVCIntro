using MVC_Intro.ConstrainingRoutes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Intro
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Default1",
               url: "Deepak",
               defaults: new { controller = "Employee", action = "Index", id = UrlParameter.Optional },
               constraints: new { abc= new clsConstraint() }
           );


            routes.MapRoute(
               name: "Default2",
               url: "Search",
               defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
           );

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index" }
            //);

            routes.MapRoute(
                 name: "ConstrainingRoutes",
                 url: "{controller}/{action}",
                 defaults: new { controller = "Student", action = "Index" },
                 constraints: new {Controller = "^S.*", action= "GetList" },
                 namespaces:new[] { "MVC_Intro.Controllers" }
             );
        }
    }
}
