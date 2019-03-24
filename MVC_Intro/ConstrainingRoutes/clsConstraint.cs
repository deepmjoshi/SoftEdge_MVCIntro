using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MVC_Intro.ConstrainingRoutes
{
    public class clsConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            //logic coming soon...
           // httpContext.Request.Headers[]
            return false;
        }
    }
}