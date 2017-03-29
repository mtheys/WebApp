using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Monsoon.Startup))]
namespace Monsoon
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
