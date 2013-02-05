using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKASP.DOMAIN.Abstract;
using SKASP.DOMAIN.EntitiesModel;

namespace SKASP.DOMAIN.Concrete
{
	/// <summary>
	/// The ef forum repository.
	/// </summary>
	public class EFForumRepository : IForumRepository
	{
		/// <summary>
		/// The data context.
		/// </summary>
		private DatabaseEntities dataContext = new DatabaseEntities();

		/// <summary>
		/// The credential context.
		/// </summary>
		private UsersContext credentialContext = new UsersContext();

		/// <summary>
		/// The message repository.
		/// </summary>
		private readonly ForumMessageRepository messageRepository = new ForumMessageRepository();

		/// <summary>
		/// The topic repository.
		/// </summary>
		private readonly ForumTopicRepository topicRepository = new ForumTopicRepository();

		/// <summary>
		/// The theme repository.
		/// </summary>
		private readonly ForumThemeRepository themeRepository = new ForumThemeRepository();

		/// <summary>
		/// Gets the messages.
		/// </summary>
		public IManageable<Message> Messages
		{
			get
			{
				return this.messageRepository;
			}
		}

		/// <summary>
		/// Gets the topics.
		/// </summary>
		public IManageable<Topic> Topics
		{
			get
			{
				return this.topicRepository;
			}
		}

		/// <summary>
		/// Gets the themes.
		/// </summary>
		public IManageable<Theme> Themes
		{
			get
			{
				return this.themeRepository;
			}
		}
	}
}
