using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FuncoGallery.Startup))]
namespace FuncoGallery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
