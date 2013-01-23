using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SKASP.WEB.Internal
{
	using System.Web.Http.Dependencies;

	using Ninject;

	/// <summary>
	/// The ninject dependency resolver.
	/// </summary>
	public class NinjectDependencyResolver : NinjectDependencyScope, System.Web.Mvc.IDependencyResolver
	{
		/// <summary>
		/// The _kernel.
		/// </summary>
		private readonly IKernel _kernel;

		/// <summary>
		/// Initializes a new instance of the <see cref="NinjectDependencyResolver"/> class.
		/// </summary>
		/// <param name="kernel">
		/// The kernel.
		/// </param>
		public NinjectDependencyResolver(IKernel kernel)
			: base(kernel)
		{
			_kernel = kernel;
		}

		/// <summary>
		/// The begin scope.
		/// </summary>
		/// <returns>
		/// The <see cref="IDependencyScope"/>.
		/// </returns>
		public IDependencyScope BeginScope()
		{
			return new NinjectDependencyScope(_kernel.BeginBlock());
		}

		/// <summary>
		/// The dispose.
		/// </summary>
		public override void Dispose()
		{
			_kernel.Dispose();
		}
	}
}