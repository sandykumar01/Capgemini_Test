using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CapgeminiTest.Startup))]
namespace CapgeminiTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
