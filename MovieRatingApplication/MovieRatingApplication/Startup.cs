using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieRatingApplication.Startup))]
namespace MovieRatingApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
