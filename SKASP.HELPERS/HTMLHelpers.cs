using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SKASP.HELPERS
{
	using System.Web;

	using SKASP.DOMAIN.EntitiesModel;

	public static class HTMLHelpers
    {
		public static IHtmlString NewsViewer(this HtmlHelper context, News entry)
		{
			string html = string.Empty;
			html =
				string.Format(
					"<div class=\"span12 well well-large\">" + "<h2>{0}</h2>" + "<p>{1}</p>" + "<p>{2}</p>"
					+ "<i class=\"divider\"></i>" + "<p>" + "<a class=\"btn\" href=\"/Home/Default/{3}\">View details &raquo;</a>" + "</p></div>",
				entry.Name,
				entry.NewsContent,
				entry.Date.Value.ToLongDateString() ?? "",
				(int)entry.ID);
			return context.Raw(html);
		}
    }
}
