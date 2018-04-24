using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThreeFavoriteColors.Startup))]
namespace ThreeFavoriteColors
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
