using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServiceManager.Startup))]
namespace ServiceManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
