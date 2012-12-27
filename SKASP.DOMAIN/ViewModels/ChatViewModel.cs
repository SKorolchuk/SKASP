namespace SKASP.DOMAIN.ViewModels
{
    using System.Linq;

    using SKASP.DOMAIN.Abstract;
    using SKASP.DOMAIN.Auth;
    using SKASP.DOMAIN.EntitiesModel;
	
	public class MessageViewModel
	{
        public IMessageRepository MessageRepo { get; private set; }
		public MessageStorage CurrrentMessage {get; set; }
        public User CurrentUser { get; private set; }
	}
}