using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Föreläsning7___Tester.Startup))]
namespace Föreläsning7___Tester
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
