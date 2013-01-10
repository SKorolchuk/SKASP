// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IForumRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The ForumRepository interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using SKASP.DOMAIN.EntitiesModel;

namespace SKASP.DOMAIN.Abstract
{
	/// <summary>
	/// The ForumRepository interface.
	/// </summary>
	public interface IForumRepository
    {
		/// <summary>
		/// Gets the messages.
		/// </summary>
		IManageable<Message> Messages { get; }

		/// <summary>
		/// Gets the topics.
		/// </summary>
		IManageable<Topic> Topics { get; }

		/// <summary>
		/// Gets the themes.
		/// </summary>
		IManageable<Theme> Themes { get; }
    }
}