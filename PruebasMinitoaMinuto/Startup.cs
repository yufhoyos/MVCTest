using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebasMinitoaMinuto.Startup))]
namespace PruebasMinitoaMinuto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
