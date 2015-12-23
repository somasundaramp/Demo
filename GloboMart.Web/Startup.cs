using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GloboMart.Web.Startup))]
namespace GloboMart.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
