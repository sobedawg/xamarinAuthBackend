using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CeLockService.Startup))]

namespace CeLockService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}