using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloSite.Startup))]
namespace HelloSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
