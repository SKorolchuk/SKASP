using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Web.Routing;
using SKASP.DOMAIN.Abstract;
using SKASP.DOMAIN.Concrete;

namespace SKASP.WEB.Internal
{
	  /// <summary>
    /// The io c controller factory.
    /// </summary>
    public class IoCControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public IoCControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
          ninjectKernel.Bind<INewsRepository>().To<EFNewsRepository>();
					ninjectKernel.Bind<IMessageRepository>().To<MessageRepository>();
					ninjectKernel.Bind<IForumRepository>().To<ForumRepository>();
	        ninjectKernel.Bind<IForumMessageRepository>().To<ForumMessageRepository>();
	        ninjectKernel.Bind<IForumThemeRepository>().To<ForumThemeRepository>();
	        ninjectKernel.Bind<IForumTopicRepository>().To<ForumTopicRepository>();
        }
    }
}