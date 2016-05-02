using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Föreläsnign_3___Views.Startup))]
namespace Föreläsnign_3___Views
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
