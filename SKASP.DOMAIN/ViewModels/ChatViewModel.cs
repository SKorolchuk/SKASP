// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChatViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   The message view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

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
		//TODO: Change to User class type

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
            CurrrentMessage = new MessageStorage();
			CurrentUser = user;
		}

		/// <summary>
		/// The reload current message.
		/// </summary>
		/// <param name="user">
		/// The user.
		/// </param>
		public void ReloadCurrentMessage()
		{
			this.CurrrentMessage = new MessageStorage()
				                       {
					                       ID = (new Random((int)DateTime.Now.Ticks)).Next(int.MinValue, int.MaxValue),
										   MsgOwner = CurrentUser
				                       };
		}
	}
}