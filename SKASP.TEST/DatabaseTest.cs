// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DatabaseTest.cs" company="">
//   
// </copyright>
// <summary>
//   The database test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SKASP.TEST
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
		public void TestNewsAndUsrTbl()
		{
			using (DatabaseEntities context = new DatabaseEntities())
			{
				int count_news = (from msg in context.News select msg).Count();
				Assert.IsTrue(count_news > 0);
			}
		}

		/// <summary>
		/// The test news and usr tbl writing.
		/// </summary>
		[TestMethod]
		public void TestNewsAndUsrTblWriting()
		{
			using (DatabaseEntities context = new DatabaseEntities())
			{
				News entity = new News { Date = DateTime.Now, ID = 123456, Name = "Hello", NewsContent = "World" };
				context.News.Add(entity);
				context.SaveChanges();
				context.News.Remove(entity);
				context.SaveChanges();
			}
		}

		/// <summary>
		/// The test message storage repo writing.
		/// </summary>
		[TestMethod]
		public void TestMessageStorageRepoWriting()
		{
			using (DatabaseEntities context = new DatabaseEntities())
			{
				MessageStorage message = new MessageStorage { ID = 100000, MsgOwner = "Srg", Data = "Hello", Name = "World" };
				context.MessageStorages.Add(message);
				context.SaveChanges();
				context.MessageStorages.Remove(message);
				context.SaveChanges();
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
				News newsItm = new News { Date = DateTime.Now, ID = 356, Name = "Test", NewsContent = "Testing" };
				context.News.Add(newsItm);
				Theme newTheme = new Theme
				{
					Created_on = DateTime.Now,
					ID = (new Random((int)DateTime.Now.Ticks)).Next(),
					Name = "Test Theme",
					Description = "Hello World",
					Subgroup = "All"
				};
				Topic newTopic = new Topic()
				{
					Created_on = DateTime.Now,
					Description = "Hello world topic",
					ID = (new Random((int)DateTime.Now.Ticks)).Next(),
					Name = "Test Topic",
					Theme = newTheme.ID
				};
				Message newMessage = new Message()
				{
					Created_on = DateTime.Now,
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
				Assert.IsTrue(context.Messages.Count(x => x.ID == newMessage.ID) > 0);
				context.Themes.Remove(newTheme);
				context.Topics.Remove(newTopic);
				context.Messages.Remove(newMessage);
				context.News.Remove(newsItm);
				context.SaveChanges();
			}
		}
	}
}
