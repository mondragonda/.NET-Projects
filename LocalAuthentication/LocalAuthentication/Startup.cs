using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LocalAuthentication.Startup))]
namespace LocalAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
