using PractiveMVC5App.Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;

namespace PractiveMVC5App.Infrastructure
{
    public class UnityConfigurator
    {
        public static void ConfigureIOCContainer()
        {
            IUnityContainer unityContainer = new UnityContainer();
            registerServices(unityContainer);
            DependencyResolver.SetResolver(new DependencyResolution(unityContainer));
        }

        private static void registerServices(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<IDataAccesser, DataAccesser>();
        }
    }
}