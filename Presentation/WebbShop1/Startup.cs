using System.Collections.Generic;
using System.Web.ModelBinding;
using Microsoft.Owin;
using Owin;
using WebbShop1.Models;

[assembly: OwinStartupAttribute(typeof(WebbShop1.Startup))]
namespace WebbShop1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            //TODO: Används sessions istället och skapa inte ordern fören den är konfirmerad
            ConfigureAuth(app);
        }
    }
}
