using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SKASP.WEB.Controllers
{
	using ReaderEx;

	public class RSSController : Controller
    {
        public Dictionary<string, string> links;
        public List<NewsTrack> Trackers;

        public List<string> RSSList; 
        
        public ViewResult Rss(string FeedUrl = "tut")
        {
            links = new Dictionary<string, string>();
            RSSList = new List<string>();
            links.Add("tut", "http://news.tut.by/rss/index.rss");
            links.Add("habr", "http://habrahabr.ru/rss/best/");
            links.Add("it_tut", "http://news.tut.by/rss/it/all.rss");
            string link = string.Empty;
            Trackers = new List<NewsTrack>();
            RSSList.Clear();
            Trackers.Clear();
            switch (FeedUrl)
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
            if (link != string.Empty) LoadChannel(link);
            return this.View(RSSList);
        }

        [NonAction]
        private void LoadChannel(string Path)
        {
            NewsTrack tracker = new NewsTrack(Path);
            Trackers.Add(tracker);
            tracker.Name = tracker.RssChannel.Title;
            foreach (var i in from s in tracker.RssChannel.News select new { Title = s.Title, Url = s.Url })
            {
                this.RSSList.Add(string.Format("{0}\n{1}", i.Title, i.Url));
            }
        }
		protected void RSSList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var link = string.Empty;
            foreach (NewsTrack track in Trackers)
            {
                foreach (Item i in track.RssChannel.News.Where(i => this.RSSList.Contains(i.Title)))
                {
                    link = i.Url;
                    this.Response.Redirect(link);
                }
            }
        }
    }
}
