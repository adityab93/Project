using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;

namespace PractiveMVC5App.Infrastructure
{
    public class DependencyResolution : IDependencyResolver
    {
        private IUnityContainer _container;
        public DependencyResolution(IUnityContainer container)
        {
            _container = container;
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return _container.Resolve(serviceType);

            }
            catch {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _container.ResolveAll(serviceType);

            }
            catch
            {
                return new List<object>();
            }
        }
    }
}