// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChatViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   The message view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Linq;

using SKASP.DOMAIN.Abstract;
using SKASP.DOMAIN.EntitiesModel;

namespace SKASP.DOMAIN.ViewModels
{
	using System;

	/// <summary>
	/// The message view model.
	/// </summary>
	public class MessageViewModel
	{
		/// <summary>
		/// Gets or sets the message repo.
		/// </summary>
		public IManageable<MessageStorage> MessageRepo { get; set; }

		/// <summary>
		/// Gets or sets the currrent message.
		/// </summary>
		public MessageStorage CurrrentMessage {get; set; }

		/// <summary>
		/// Gets or sets the current user.
		/// </summary>
		public string CurrentUser { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="MessageViewModel"/> class.
		/// </summary>
		/// <param name="user">
		/// The user.
		/// </param>
		public MessageViewModel(string user = "")
		{
			this.CurrrentMessage = new MessageStorage { MsgOwner = user };
			this.CurrentUser = user;
		}

		/// <summary>
		/// The reload current message.
		/// </summary>
		public void ReloadCurrentMessage()
		{
			try
			{
				this.CurrrentMessage = new MessageStorage()
											{
												ID = this.MessageRepo.Repository.Max(x => x.ID) + 1,
												MsgOwner = this.CurrentUser
											};
			}
			catch (Exception ex)
			{
				this.CurrrentMessage = new MessageStorage()
											{
												ID = 0,
												MsgOwner = this.CurrentUser
											};
			}
		}
	}
}