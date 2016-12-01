using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI.WebControls;

namespace PresentationEpiserver
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            //Tip: Want to call the EPiServer API on startup? Add an initialization module instead (Add -> New Item.. -> EPiServer -> Initialization Module)
        }



        //protected override void RegisterRoutes(RouteCollection routes)
        //{
        //    base.RegisterRoutes(routes);

        //    routes.MapRoute(
        //        name: "ShopCustomRoute",
        //        url: "BasePageController/{action}/{id}",
        //        defaults: new { controller = "StartPageContoller", action = "Index", id = UrlParameter.Optional });
        //}
    }

}