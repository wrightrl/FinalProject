using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalCountdown.Startup))]
namespace FinalCountdown
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
