using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAzurAPP.Startup))]
namespace TestAzurAPP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
