using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(memberships.Startup))]
namespace memberships
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
