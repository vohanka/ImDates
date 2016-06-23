using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ImDatesAsp.Startup))]
namespace ImDatesAsp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
