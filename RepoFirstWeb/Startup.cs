using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RepoFirstWeb.Startup))]
namespace RepoFirstWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
