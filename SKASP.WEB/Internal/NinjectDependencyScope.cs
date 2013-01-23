using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SKASP.WEB.Internal
{
	using System.Web.Http.Dependencies;

	using Ninject.Parameters;
	using Ninject.Syntax;

	/// <summary>
	/// The ninject dependency scope.
	/// </summary>
	public class NinjectDependencyScope : IDependencyScope
	{
		/// <summary>
		/// The resolution root.
		/// </summary>
		protected IResolutionRoot ResolutionRoot;

		/// <summary>
		/// Initializes a new instance of the <see cref="NinjectDependencyScope"/> class.
		/// </summary>
		/// <param name="kernel">
		/// The kernel.
		/// </param>
		public NinjectDependencyScope(IResolutionRoot kernel)
		{
			this.ResolutionRoot = kernel;
		}

		/// <summary>
		/// The get service.
		/// </summary>
		/// <param name="serviceType">
		/// The service type.
		/// </param>
		/// <returns>
		/// The <see cref="object"/>.
		/// </returns>
		public object GetService(Type serviceType)
		{
			var request = ResolutionRoot.CreateRequest(serviceType, null, new Parameter[0], true, true);
			return ResolutionRoot.Resolve(request).SingleOrDefault();
		}

		/// <summary>
		/// The get services.
		/// </summary>
		/// <param name="serviceType">
		/// The service type.
		/// </param>
		/// <returns>
		/// The <see cref="IEnumerable"/>.
		/// </returns>
		public IEnumerable<object> GetServices(Type serviceType)
		{
			var request = ResolutionRoot.CreateRequest(serviceType, null, new Parameter[0], true, true);
			return ResolutionRoot.Resolve(request).ToList();
		}

		/// <summary>
		/// The dispose.
		/// </summary>
		public virtual void Dispose()
		{
			var disposable = (IDisposable)ResolutionRoot;
			if (disposable != null) disposable.Dispose();
			ResolutionRoot = null;
		}
	}
}