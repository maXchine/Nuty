using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nuty.Mvc.Startup))]
namespace Nuty.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
