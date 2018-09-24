using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleLogix_MultiTenantApp.Startup))]
namespace SimpleLogix_MultiTenantApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
