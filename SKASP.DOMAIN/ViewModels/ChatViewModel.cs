using System.Linq;
using SKASP.DOMAIN.Abstract;
using SKASP.DOMAIN.EntitiesModel;

namespace SKASP.DOMAIN.ViewModels
{
	public class MessageViewModel
	{
        public IMessageRepository MessageRepo { get; set; }
		public MessageStorage CurrrentMessage {get; set; }
		//TODO: Change to User class type
        public string CurrentUser { get; set; }
		
		public MessageViewModel(string user = "")
		{
            CurrrentMessage = new MessageStorage();
			CurrentUser = user;
		}
	}
}