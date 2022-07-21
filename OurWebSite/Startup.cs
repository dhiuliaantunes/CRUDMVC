using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OurWebSite.Startup))]
namespace OurWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
