using Hexagonal.DesignPatterns.DIUsingUnityIoC.Interfaces;
using Hexagonal.DesignPatterns.DIUsingUnityIoC.Models;
using Microsoft.Practices.Unity;
using System.Web.Mvc;
using Unity.Mvc4;


namespace Hexagonal.DesignPatterns.DIUsingUnityIoC.DepedencyInjection
{
    public class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>(); 
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IProduct, Product>();

            RegisterTypes(container);

            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}