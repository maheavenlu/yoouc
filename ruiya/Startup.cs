using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ruiya.Startup))]
namespace ruiya
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
