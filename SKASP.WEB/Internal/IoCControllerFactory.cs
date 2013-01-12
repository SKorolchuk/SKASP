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
	using SKASP.DOMAIN.EntitiesModel;

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
          ninjectKernel.Bind<IManageable<News>>().To<EFNewsRepository>();
					//ninjectKernel.Bind<IManageable<MessageStorage>>().To<MessageRepository>();
					ninjectKernel.Bind<IForumRepository>().To<EFForumRepository>();
	        ninjectKernel.Bind<IManageable<Message>>().To<ForumMessageRepository>();
	        ninjectKernel.Bind<IManageable<Theme>>().To<ForumThemeRepository>();
	        ninjectKernel.Bind<IManageable<Topic>>().To<ForumTopicRepository>();
        }
    }
}