namespace SKASP.DOMAIN.ViewModels
{
    using System.Linq;

    using SKASP.DOMAIN.EntitiesModel;
	
	public class MessageViewModel
	{
		public IMessageRepository MessageRepo { get; }
		public MessageStorage CurrrentMessage {get; set; }
		public User CurrentUser { get; }
	}
}