using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SKASP.WEB
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			
			routes.MapHttpRoute(
				name: "RESTServicesRoute",
				url: "REST/{controller}/{id}",
				defaults: new { controller = "RestApi", id = RouteParameter.Optional }
			);
			
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Default", id = "All" }
            );
        }
    }
}