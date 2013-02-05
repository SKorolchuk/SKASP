using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using SKASP.DOMAIN.Concrete;
using SKASP.WEB.App_Start;
using SKASP.WEB.Controllers;
using SKASP.WEB.Internal;

namespace SKASP.WEB
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			RouteTable.Routes.MapHubs();
			WebApiConfig.Register(GlobalConfiguration.Configuration);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			//BootstrapBundleConfig.RegisterBundles();
			//BundleConfig.RegisterBundles(BundleTable.Bundles);
			AuthConfig.RegisterAuth();
			var kernel = new IoCControllerKernel();
			DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel.ninjectKernel));
		}
	}
}