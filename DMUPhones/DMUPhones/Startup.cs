using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DMUPhones.Startup))]
namespace DMUPhones
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
