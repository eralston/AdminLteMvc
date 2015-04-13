using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdminLteMvc.Startup))]
namespace AdminLteMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
