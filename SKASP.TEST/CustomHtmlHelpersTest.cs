using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SKASP.TEST
{
	using System.Web.Mvc;

	using SKASP.DOMAIN.EntitiesModel;
	using SKASP.HELPERS;

	/// <summary>
	/// The custom html helpers test.
	/// </summary>
	[TestClass]
	public class CustomHtmlHelpersTest
	{
		/// <summary>
		/// The news viewer test.
		/// </summary>
		[TestMethod]
		public void NewsViewer()
		{
			News ent = new News()
							{
								ID = 1,
								Date = DateTime.Now,
								Name = "Test",
								NewsContent = "<i>Hello world!</i>"
							};

			var html = string.Format(
					"<div class=\"span12 well well-large\">" + "<h2>{0}</h2>" + "<p>{1}</p>" + "<p>{2}</p>"
					+ "<i class=\"divider\"></i>" + "<p>" + "<a class=\"btn\" href=\"/Home/Default/{3}\">View details &raquo;</a>" + "</p></div>",
				ent.Name,
				ent.NewsContent,
				ent.Date.Value.ToLongDateString() ?? "",
				ent.ID);
			Assert.IsTrue(html == (new HtmlHelper<News>(new ViewContext(), new ViewPage())).NewsViewer(ent).ToHtmlString());
		}
	}
}
