using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IntroductionToASPNETMVC.Startup))]
namespace IntroductionToASPNETMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
