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
            DatabaseTest.TestForumFunctionality();
            DatabaseTest.TestNewsAndUsrTbl();
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
    public static class DatabaseTest
    {
        /// <summary>
        /// The test news and usr tbl.
        /// </summary>
        public static void TestNewsAndUsrTbl()
        {
            using (DatabaseEntities context = new DatabaseEntities())
            {
                int count_news = (from msg in context.News select msg).Count();
                int count_usr = (from usr in context.Usr_lg_data select usr).Count();
            }
        }

        /// <summary>
        /// The test forum functionality.
        /// </summary>
        public static void TestForumFunctionality()
        {
            using (DatabaseEntities context = new DatabaseEntities())
            {
                //context.News.Add(new News{Date = DateTime.Now, ID = 3456, Name = "Test", NewsContent = "Testing"});
                Usr_lg_data user = context.Usr_lg_data.FirstOrDefault(x => x.id == 1);
                Theme newTheme = new Theme
                {
                    Created_on = DateTime.Now,
                    ID = (new Random((int)DateTime.Now.Ticks)).Next(),
                    Creator = user.id,
                    Name = "Test Theme",
                    Description = "Hello World",
                    Subgroup = "All"
                };
                Topic newTopic = new Topic()
                {
                    Created_on = DateTime.Now,
                    Creator = user.id,
                    Description = "Hello world topic",
                    ID = (new Random((int)DateTime.Now.Ticks)).Next(),
                    Name = "Test Topic",
                    Theme = newTheme.ID
                };
                Message newMessage = new Message()
                {
                    Created_on = DateTime.Now,
                    Creator = user.id,
                    ID = (new Random((int)DateTime.Now.Ticks)).Next(),
                    Text = "hello",
                    Topic = newTopic.ID
                };
                context.Themes.Add(newTheme);
                context.Topics.Add(newTopic);
                context.Messages.Add(newMessage);
                context.SaveChanges();
                context.Themes.Remove(newTheme);
                context.Topics.Remove(newTopic);
                context.Messages.Remove(newMessage);
                context.SaveChanges();
            }
        }
    }
}
