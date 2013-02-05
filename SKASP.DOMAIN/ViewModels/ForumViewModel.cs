// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ForumViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   The forum place.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SKASP.DOMAIN.ViewModels
{
    using System.Linq;

    using SKASP.DOMAIN.Abstract;
    using SKASP.DOMAIN.EntitiesModel;

	/// <summary>
	/// The forum place.
	/// </summary>
	public enum ForumPlace 
	{
		/// <summary>
		/// The theme list.
		/// </summary>
		ThemeList,

		/// <summary>
		/// The topic list.
		/// </summary>
		TopicList,

		/// <summary>
		/// The message list.
		/// </summary>
		MessageList
	}

	/// <summary>
	/// The forum view model.
	/// </summary>
	public class ForumViewModel
	{
		/// <summary>
		/// Gets or sets the place.
		/// </summary>
		public ForumPlace Place { get; set; }

		/// <summary>
		/// Gets the forum repo.
		/// </summary>
		public IForumRepository ForumRepo { get; private set; }

		/// <summary>
		/// Gets or sets the currrent message.
		/// </summary>
		public Message CurrrentMessage {get; set; }

		/// <summary>
		/// Gets or sets the current topic.
		/// </summary>
		public Topic CurrentTopic { get; set; }

		/// <summary>
		/// Gets or sets the current theme.
		/// </summary>
		public Theme CurrentTheme { get; set; }

		/// <summary>
		/// Gets or sets the curremt message.
		/// </summary>
		public Message CurremtMessage { get; set; }
	}
}