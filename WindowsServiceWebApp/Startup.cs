using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WindowsServiceWebApp.Startup))]
namespace WindowsServiceWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
