using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SKASP.DOMAIN.Abstract;
using SKASP.DOMAIN.EntitiesModel;

namespace SKASP.WEB.Controllers
{
	/// <summary>
	/// The forum controller.
	/// </summary>
	public class ForumController : Controller
	{
		/// <summary>
		/// The repository.
		/// </summary>
		private readonly IForumRepository repository;

		/// <summary>
		/// Initializes a new instance of the <see cref="ForumController"/> class.
		/// </summary>
		/// <param name="repo">
		/// The repo.
		/// </param>
		public ForumController(IForumRepository repo)
		{
			repository = repo;
		}

		/// <summary>
		/// The themes.
		/// </summary>
		/// <returns>
		/// The <see cref="ActionResult"/>.
		/// </returns>
		[Authorize]
        public ActionResult Themes()
        {
            return View(repository.Themes);
        }

		/// <summary>
		/// The create theme.
		/// </summary>
		/// <param name="item">
		/// The item.
		/// </param>
		/// <returns>
		/// The <see cref="ActionResult"/>.
		/// </returns>
		[Authorize]
		[HttpPost]
		public ActionResult CreateTheme(Theme item)
		{
			if (ModelState.IsValid)
			{
				repository.Themes.AddValue(item);
			}
			return RedirectToAction("Themes");
		}

		/// <summary>
		/// The topics.
		/// </summary>
		/// <param name="id">
		/// The id.
		/// </param>
		/// <returns>
		/// The <see cref="ActionResult"/>.
		/// </returns>
		[Authorize]
		public ActionResult Topics(int id)
		{
			List<Topic> topics = repository.Topics.Repository.Where(x => x.ID == id).ToList();
			return this.View(topics);
		}
    }
}
