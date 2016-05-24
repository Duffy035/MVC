using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMedEntity__Globalasax.Startup))]
namespace TestMedEntity__Globalasax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
