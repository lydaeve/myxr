using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myxr.Startup))]
namespace myxr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
