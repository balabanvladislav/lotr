using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LOTR.Startup))]
namespace LOTR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
