using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SKASP.WEB.Controllers
{
    using SKASP.DOMAIN.Abstract;
    using SKASP.DOMAIN.Concrete;
    using SKASP.DOMAIN.EntitiesModel;

    public class HomeController : Controller
    {
        public int PageSize = 4;

        private IManageable<News> repo;

		public HomeController(IManageable<News> repository)
        {
            repo = repository;
        }

        public ViewResult Default(string id)
        {
            int Id;
            if (id == "All") return this.View(repo);
            else if (int.TryParse(id, out Id))
            {
                return this.View("NewsViewer", this.repo.Repository.First(x => x.ID == Id));
            }
            else
            {
                return this.View(repo);
            }
        }
        [Authorize]
        public ViewResult About()
        {
            return this.View();
        }
    }
}
