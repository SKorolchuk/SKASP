using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SKASP.WEB.Controllers
{
	using SKASP.DOMAIN.EntitiesModel;

	public class AJAXController : Controller
    {
        //
        // GET: /AJAX/

        public ActionResult Index()
        {
	        News test = new News { ID = 1, Date = DateTime.Now, Name = "Test", NewsContent = "Hello World"};
            return Json(test, JsonRequestBehavior.AllowGet);
        }

		[HttpPost]
		public ActionResult Index(string message)
		{
			News test = new News { ID = 1, Date = DateTime.Now, Name = "Test", NewsContent = message };
			return Json(test, JsonRequestBehavior.AllowGet);
		}

		public ActionResult Testing()
		{
			return this.View();
		}

		public ActionResult Jquery()
		{
			return this.View();
		}
    }
}
