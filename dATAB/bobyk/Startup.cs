using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bobyk.Startup))]
namespace bobyk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
