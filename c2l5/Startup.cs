using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(c2l5.Startup))]
namespace c2l5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
