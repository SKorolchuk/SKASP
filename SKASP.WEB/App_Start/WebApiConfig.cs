// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WebApiConfig.cs" company="">
//   
// </copyright>
// <summary>
//   The web api config.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SKASP.WEB
{
	/// <summary>
	/// The web api config.
	/// </summary>
	public static class WebApiConfig
	{
		/// <summary>
		/// The register.
		/// </summary>
		/// <param name="config">
		/// The config.
		/// </param>
		public static void Register(HttpConfiguration config)
		{
			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional });
		}
	}
}
