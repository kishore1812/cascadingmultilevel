using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cascading2.Startup))]
namespace cascading2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
