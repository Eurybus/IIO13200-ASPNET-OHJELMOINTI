using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IIO13200_ASPNET_OHJELMOINTI.Startup))]
namespace IIO13200_ASPNET_OHJELMOINTI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
