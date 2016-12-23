using System.Web.Http;
using System.Web.Mvc;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc.Html;
using StructureMap;

namespace PresentationEpiserver
{
    [InitializableModule]
    [ModuleDependency(typeof(ServiceContainerInitialization))]
    public class StructureMapDependencyResolverInitialization : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.Container.Configure(ConfigureContainer);

            var resolver = new StructureMapDependencyResolver(context.Container);

            // ASP.NET MVC activation
            DependencyResolver.SetResolver(resolver);

            //ASP.NET Web API activation
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }

        private static void ConfigureContainer(ConfigurationExpression configuration)
        {

        }

        public void Initialize(InitializationEngine context)
        {
        }

        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}