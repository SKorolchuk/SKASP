using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SKASP.WEB.Controllers
{
	using SKASP.DOMAIN.Abstract;
using SKASP.DOMAIN.EntitiesModel;

	public class ForumController : Controller
	{
		private IForumRepository repository;

		public ForumController(IForumRepository repo)
		{
			repository = repo;
		}

		[Authorize]
        public ActionResult Themes()
        {
            return View(repository.Themes);
        }

		[Authorize]
		[HttpPost]
		public ActionResult CreateTheme(Theme item)
		{
			if (ModelState.IsValid)
			{
				
			}
		}

		[Authorize]
		public ActionResult Topics(int id)
		{
			List<Topic> topics = repository.Topics.Updates.Where(x => x.ID == id).ToList();
			return this.View(topics);
		}
    }
}
