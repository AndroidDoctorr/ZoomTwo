using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZoomTwo.WebMVC.Startup))]
namespace ZoomTwo.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
