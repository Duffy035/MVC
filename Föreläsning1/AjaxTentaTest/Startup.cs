using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxTentaTest.Startup))]
namespace AjaxTentaTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
