using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NWCustomer.Startup))]
namespace NWCustomer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
