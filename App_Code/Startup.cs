using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyRepo.Startup))]
namespace MyRepo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
