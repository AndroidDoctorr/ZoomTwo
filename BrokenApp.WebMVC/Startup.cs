using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BrokenApp.WebMVC.Startup))]
namespace BrokenApp.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
