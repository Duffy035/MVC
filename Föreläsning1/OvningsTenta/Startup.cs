using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OvningsTenta.Startup))]
namespace OvningsTenta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
