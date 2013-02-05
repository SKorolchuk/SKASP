using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

using Microsoft.AspNet.SignalR;

namespace SKASP.WEB
{
	/// <summary>
	/// The route config.
	/// </summary>
	public class RouteConfig
	{
		/// <summary>
		/// The register routes.
		/// </summary>
		/// <param name="routes">
		/// The routes.
		/// </param>
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "Home", action = "Default", id = "All" });
		}
	}
}