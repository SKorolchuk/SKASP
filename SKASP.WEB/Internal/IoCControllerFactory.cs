using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;

namespace SKASP.WEB.Internal
{
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Web.Routing;

    using SKASP.DOMAIN.Abstract;
    using SKASP.DOMAIN.Concrete;

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
            // Mock Implementation
           /* Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new List<Product>
                                                    {
                                                        new Product() {Name = "C# via CLR", Description = "The best C# book", Price = 60},
                                                        new Product() {Name = "Pro ASP.NET MVC 3", Description = "Book for ASP.NET Proffesionals", Price = 100},
                                                        new Product() {Name = "JavaScript: The Definitive Guide", Description = "The best for Front-end devs", Price = 120}
                                                    }.AsQueryable());
            ninjectKernel.Bind<IProductRepository>().ToConstant(mock.Object);*/

            //entity framework realization

            ninjectKernel.Bind<INewsRepository>().To<EFNewsRepository>();
        }
    }
}