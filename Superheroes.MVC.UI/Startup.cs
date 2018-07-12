using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Superheroes.MVC.UI.Startup))]
namespace Superheroes.MVC.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
