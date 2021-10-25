using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GighubMVCFixed.Startup))]
namespace GighubMVCFixed
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
