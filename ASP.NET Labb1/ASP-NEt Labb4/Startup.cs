using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_NEt_Labb4.Startup))]
namespace ASP_NEt_Labb4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
