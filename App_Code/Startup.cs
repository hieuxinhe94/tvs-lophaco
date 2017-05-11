using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DuocPhamLophaco.Startup))]
namespace DuocPhamLophaco
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
