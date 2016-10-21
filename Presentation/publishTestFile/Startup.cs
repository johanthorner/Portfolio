using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(publishTestFile.Startup))]
namespace publishTestFile
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
