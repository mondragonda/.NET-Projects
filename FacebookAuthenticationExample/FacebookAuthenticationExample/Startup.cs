using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FacebookAuthenticationExample.Startup))]
namespace FacebookAuthenticationExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
