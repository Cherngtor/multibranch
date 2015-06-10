using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcMultibranch.Startup))]
namespace mvcMultibranch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
