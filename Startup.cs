using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(autotication.Startup))]
namespace autotication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
