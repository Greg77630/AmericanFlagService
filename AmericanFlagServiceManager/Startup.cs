using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AmericanFlagServiceManager.Startup))]
namespace AmericanFlagServiceManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
