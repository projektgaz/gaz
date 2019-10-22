using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(G.A.Z.SIOS.Startup))]
namespace G.A.Z.SIOS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
