using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobTracker.Startup))]
namespace JobTracker
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
