using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthAssist.MVC.Startup))]
namespace HealthAssist.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
