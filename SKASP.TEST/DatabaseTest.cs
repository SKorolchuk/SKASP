using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNETPractiseWEBMVC4.Tests
{
    using System.Linq;

    using SKASP.DOMAIN.EntitiesModel;

    /// <summary>
    /// The database test.
    /// </summary>
    [TestClass]
    public class DatabaseTest
    {
        /// <summary>
        /// The test news and usr tbl.
        /// </summary>
        [TestMethod]
        private void TestNewsAndUsrTbl()
        {
            using (DatabaseEntities context = new DatabaseEntities())
            {
                int count_news = (from msg in context.News select msg).Count();
                int count_usr = (from usr in context.Usr_lg_data select usr).Count();
                Assert.IsTrue(count_news > 0);
                Assert.IsTrue(count_usr > 0);
            }
        }

        /// <summary>
        /// The test forum functionality.
        /// </summary>
        [TestMethod]
        public void TestForumFunctionality()
        {
            using (DatabaseEntities context = new DatabaseEntities())
            {
                context.News.Add(new News{Date = DateTime.Now, ID = 3456, "Test", "Testing"});
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
                Assert.IsTrue(context.Themes.Count(x => x.ID == newTheme.ID) > 0);
                Assert.IsTrue(context.Topics.Count(x => x.ID == newTopic.ID) > 0);
                Assert.IsTrue(context.Topics.Count(x => x.ID == newMessage.ID) > 0);
                context.Themes.Remove(newTheme);
                context.Topics.Remove(newTopic);
                context.Messages.Remove(newMessage);
                context.SaveChanges();
            }
        }
    }
}
