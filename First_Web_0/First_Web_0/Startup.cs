using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(First_Web_0.Startup))]
namespace First_Web_0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
