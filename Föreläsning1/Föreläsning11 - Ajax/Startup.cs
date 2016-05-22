using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Föreläsning11___Ajax.Startup))]
namespace Föreläsning11___Ajax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
