using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Texcel.Startup))]
namespace Texcel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
