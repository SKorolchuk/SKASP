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

	/// <summary>
	/// The html helpers.
	/// </summary>
	public static class HTMLHelpers
	{
		/// <summary>
		/// The news viewer.
		/// </summary>
		/// <param name="context">
		/// The context.
		/// </param>
		/// <param name="entry">
		/// The entry.
		/// </param>
		/// <returns>
		/// The <see cref="IHtmlString"/>.
		/// </returns>
		public static IHtmlString NewsViewer(this HtmlHelper context, News entry)
		{
			var html = string.Format(
				"<div class=\"span12 well well-large\">" + "<h2>{0}</h2>" + "<p>{1}</p>" + "<p>{2}</p>"
				+ "<i class=\"divider\"></i>" + "<p>" + "<a class=\"btn\" href=\"/Home/Default/{3}\">View details &raquo;</a>" + "</p></div>",
				entry.Name,
				entry.NewsContent,
				entry.Date.Value.ToLongDateString() ?? string.Empty,
				entry.ID);
			return context.Raw(html);
		}
	}
}
