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

    public class ChatController : Controller
    {
		private static IManageable<MessageStorage> messages;
		private static MessageViewModel viewModel = new MessageViewModel();
		
		//TODO: change user type from string User class
		public ChatController(IManageable<MessageStorage> repo)
		{
			messages = repo;
			viewModel.CurrentUser = (User != null ? User.Identity.Name : "");
			viewModel.MessageRepo = messages;
			viewModel.ReloadCurrentMessage();
		}

		public ChatController(){}
		
		[Authorize]
		[System.Web.Mvc.HttpGet]
		public ViewResult Chat()
		{
			viewModel.CurrentUser = User.Identity.Name;
			viewModel.ReloadCurrentMessage();
            return this.View(viewModel);
        }
		
		[Authorize]
		[System.Web.Mvc.HttpPost]
		public RedirectToRouteResult PostChat(MessageStorage msg)
        {
			//TODO: realize post-redirect-get pattern here (MsgOwner == CurrentUser)
			messages.AddValue(msg);
			viewModel.ReloadCurrentMessage();
			return RedirectToAction("Chat");
        }
    }
}
