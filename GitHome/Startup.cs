using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHome.Startup))]
namespace GitHome
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
