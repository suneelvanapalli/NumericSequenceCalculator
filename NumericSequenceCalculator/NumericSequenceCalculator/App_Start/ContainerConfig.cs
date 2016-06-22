using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using NumericSequenceCalculator.API_Controllers;
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
            var assemsbly = Assembly.GetExecutingAssembly();

            builder.RegisterControllers(assemsbly);

            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;

            //WebApiConfig.Register(config);

            builder.RegisterApiControllers(typeof(SequenceAPIController).Assembly);
          //  // Register your Web API controllers.
          //  builder.RegisterApiControllers(assemsbly);

            // OPTIONAL: Register the Autofac filter provider.
            //builder.RegisterWebApiFilterProvider(config);


            builder.RegisterType<SequenceService>().As<ISequenceService>().SingleInstance();
            
            builder.RegisterFilterProvider();
            var container = builder.Build();

            // Set the dependency resolver for Web API.
            var webApiResolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = webApiResolver;

            // Set the dependency resolver for MVC.
            var mvcResolver = new AutofacDependencyResolver(container);
            DependencyResolver.SetResolver(mvcResolver);

            
        }
    }
}