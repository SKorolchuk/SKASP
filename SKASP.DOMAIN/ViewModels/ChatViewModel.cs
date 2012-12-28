namespace SKASP.DOMAIN.ViewModels
{
    using System.Linq;

    using SKASP.DOMAIN.Abstract;
    using SKASP.DOMAIN.Auth;
    using SKASP.DOMAIN.EntitiesModel;
	
	public class MessageViewModel
	{
        public IMessageRepository MessageRepo { get; set; }
		public MessageStorage CurrrentMessage {get; set; }
		//TODO: Change to User class type
        public string CurrentUser { get; set; }
		
		public MessageViewModel(string user = string.Empty)
		{
			MessageStorage = new MessageStorage();
			CurrentUser = user;
		}
	}
}