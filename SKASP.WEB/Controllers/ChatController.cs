using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SKASP.WEB.Controllers
{
    public class ChatController : Controller
    {
        public ViewResult Chat()
        {
            return this.View();
        }
    }
}
