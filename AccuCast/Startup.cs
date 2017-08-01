using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AccuCast.Startup))]
namespace AccuCast
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
