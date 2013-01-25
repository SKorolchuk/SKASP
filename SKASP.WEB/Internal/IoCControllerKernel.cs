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
    public class IoCControllerKernel
    {
        internal readonly IKernel ninjectKernel;

		public IoCControllerKernel()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
			
        }

        private void AddBindings()
        {
			ninjectKernel.Bind<IManageable<News>>().To<EFNewsRepository>().InSingletonScope();
			ninjectKernel.Bind<IManageable<MessageStorage>>().To<MessageRepository>().InSingletonScope();
			ninjectKernel.Bind<IForumRepository>().To<EFForumRepository>().InSingletonScope();
	        ninjectKernel.Bind<IManageable<Message>>().To<ForumMessageRepository>().InSingletonScope();
	        ninjectKernel.Bind<IManageable<Theme>>().To<ForumThemeRepository>().InSingletonScope();
	        ninjectKernel.Bind<IManageable<Topic>>().To<ForumTopicRepository>().InSingletonScope();
        }
    }
}