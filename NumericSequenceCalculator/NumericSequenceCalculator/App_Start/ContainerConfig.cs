using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using NumericSequenceCalculator.BusinessServices;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;

namespace NumericSequenceCalculator
{
    public class ContainerConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;

            // Register your Web API controllers.
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);

            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(config);


            builder.RegisterType<SequenceService>().As<ISequenceService>().SingleInstance();
            
            builder.RegisterFilterProvider();
            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}