using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Forelasning12___SecretOvert_Test.Startup))]
namespace Forelasning12___SecretOvert_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
