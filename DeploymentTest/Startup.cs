using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeploymentTest.Startup))]
namespace DeploymentTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
