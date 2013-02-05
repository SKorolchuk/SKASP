using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SKASP.WEB
{
	using Microsoft.AspNet.SignalR;
	using Microsoft.AspNet.SignalR.Hubs;

	using SKASP.DOMAIN.Concrete;
	[HubName("chatHub")]
	public class ChatHub : Hub
	{
		public void Send(string name, string message)
		{
			Clients.All.broadcastMessage(name, message);
		}
	}
}