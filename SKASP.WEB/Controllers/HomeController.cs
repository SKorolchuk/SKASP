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

        private INewsRepository repo;

        public HomeController(INewsRepository repository)
        {
            repo = repository;
        }

        public ViewResult Default(string id)
        {
            int Id;
            if (id == "All") return this.View(repo);
            else if (int.TryParse(id, out Id))
            {
                return this.View("NewsViewer", repo.Updates.Where(x => x.ID == Id).First());
            }
            else
            {
                return this.View(repo);
            }
        }

        public ViewResult About()
        {
            return this.View();
        }
    }
}
