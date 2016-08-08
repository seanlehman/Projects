using ElevenNote.Web.Contracts;
using ElevenNote.Web.Fakes;
using Microsoft.Owin;
using Owin;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using System.Web.Mvc;

[assembly: OwinStartupAttribute(typeof(ElevenNote.Web.Startup))]
namespace ElevenNote.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            ConfigureDependencies();
        }

        private void ConfigureDependencies()
        {
            // 1. Create a new Simple Injector container
            var container = new Container();

            // 2. Configure the container (register)
            container.Register<ILogger, FakeLogger>(Lifestyle.Transient);

            // 3. Optionally verify the containers's configuration
            container.Verify();

            // 4. Register the container as MVC3 IDependencyResolver
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}
