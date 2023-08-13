using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Emporium.Web.Startup))]
namespace Emporium.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
