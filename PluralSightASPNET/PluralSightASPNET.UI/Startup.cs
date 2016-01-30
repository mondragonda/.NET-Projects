using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PluralSightASPNET.UI.Startup))]
namespace PluralSightASPNET.UI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
