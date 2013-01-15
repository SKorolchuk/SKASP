using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SKASP.WEB.Controllers
{
	using ReaderEx;

	/// <summary>
	/// The rss controller.
	/// </summary>
	public class RSSController : Controller
    {
		/// <summary>
		/// The links.
		/// </summary>
		private Dictionary<string, string> links;

		/// <summary>
		/// The trackers.
		/// </summary>
		private List<NewsTrack> trackers;

		/// <summary>
		/// The current tracker.
		/// </summary>
		private NewsTrack currentTracker;

		/// <summary>
		/// The rss.
		/// </summary>
		/// <param name="feedUrl">
		/// The feed url.
		/// </param>
		/// <returns>
		/// The <see cref="ViewResult"/>.
		/// </returns>
		public ViewResult Rss(string feedUrl = "tut")
        {
            links = new Dictionary<string, string>
	                    {
		                    { "tut", "http://news.tut.by/rss/index.rss" },
		                    { "habr", "http://habrahabr.ru/rss/hubs/" },
		                    { "it_tut", "http://it.tut.by/rss" }
	                    };
			string link = string.Empty;
            trackers = new List<NewsTrack>();
            trackers.Clear();
            switch (feedUrl)
            {
                case "tut":
                    link = links["tut"];
                    break;
                case "habr":
                    link = links["habr"];
                    break;
                case "it_tut":
                    link = links["it_tut"];
                    break;
            }

            if (link != string.Empty)
            {
	            currentTracker = LoadChannel(link);
				return this.View(currentTracker);
            }
	        return this.View();
        }

		/// <summary>
		/// The load channel.
		/// </summary>
		/// <param name="path">
		/// The path.
		/// </param>
		/// <returns>
		/// The <see cref="NewsTrack"/>.
		/// </returns>
		[NonAction]
        private NewsTrack LoadChannel(string path)
        {
			trackers.Clear();
            NewsTrack tracker = new NewsTrack(path);
            trackers.Add(tracker);
            tracker.Name = tracker.RssChannel.Title;
	        return tracker;
        }
    }
}
