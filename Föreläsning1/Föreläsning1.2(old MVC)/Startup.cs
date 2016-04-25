using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Föreläsning1._2_old_MVC_.Startup))]
namespace Föreläsning1._2_old_MVC_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
