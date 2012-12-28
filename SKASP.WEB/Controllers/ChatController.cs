using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SKASP.WEB.Controllers
{
    using SKASP.DOMAIN.Abstract;
    using SKASP.DOMAIN.ViewModels;

    public class ChatController : Controller
    {
		private IMessageRepository messages;
		private MessageViewModel viewModel;
		
		//TODO: change user type from string User class
		private string user;
		
		public ChatController(IMessageRepository repo)
		{
			messages = repo;
			viewModel = new MessageViewModel(user);
			viewModel.MessageRepo = messages;			
		}
		
        public ViewResult Chat(string user = "")
        {
            return this.View(viewModel);
        }
		
		[HttpPost]
		public ViewResult Chat(MessageViewModel view)
        {
			//TODO: realize post-redirect-get pattern here (MsgOwner == CurrentUser)
            return this.View(view);
        }
    }
}
