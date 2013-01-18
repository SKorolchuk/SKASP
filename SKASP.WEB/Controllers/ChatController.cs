using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SKASP.WEB.Controllers
{
    using SKASP.DOMAIN.Abstract;
    using SKASP.DOMAIN.EntitiesModel;
    using SKASP.DOMAIN.ViewModels;

	[Authorize]
    public class ChatController : Controller
    {
		private IManageable<MessageStorage> messages;
		private MessageViewModel viewModel;
		
		//TODO: change user type from string User class

		public ChatController(IManageable<MessageStorage> repo)
		{
			messages = repo;
			viewModel = new MessageViewModel();
			viewModel.MessageRepo = messages;
			viewModel.ReloadCurrentMessage();
			if (User != null &&	User.Identity.IsAuthenticated)
			{
				viewModel.CurrentUser = User.Identity.Name;
			}
			else
			{
				RedirectToAction("Login", "Account");
			}
		}
		
		[HttpGet]
		public ViewResult Chat()
		{
			viewModel.CurrentUser = User.Identity.Name;
            return this.View(viewModel);
        }
		
		[HttpPost]
		public ViewResult Chat(MessageStorage msg)
        {
			//TODO: realize post-redirect-get pattern here (MsgOwner == CurrentUser)
			messages.AddValue(msg);
			viewModel.ReloadCurrentMessage();
            return this.View(viewModel);
        }

		public ActionResult SendMessage(MessageStorage msg)
		{
			return this.View(msg);
		}
    }
}
