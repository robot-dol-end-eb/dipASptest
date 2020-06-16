using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testasp.Startup))]
namespace testasp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
