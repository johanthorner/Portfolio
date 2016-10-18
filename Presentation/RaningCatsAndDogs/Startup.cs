using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RaningCatsAndDogs.Startup))]
namespace RaningCatsAndDogs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
