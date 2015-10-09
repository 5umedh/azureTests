using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gitazuretest.Startup))]
namespace gitazuretest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
