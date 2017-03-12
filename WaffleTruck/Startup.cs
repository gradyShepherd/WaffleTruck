using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WaffleTruck.Startup))]
namespace WaffleTruck
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
