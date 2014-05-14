using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Taj.Startup))]
namespace Taj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
