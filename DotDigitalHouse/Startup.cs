using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotDigitalHouse.Startup))]
namespace DotDigitalHouse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
