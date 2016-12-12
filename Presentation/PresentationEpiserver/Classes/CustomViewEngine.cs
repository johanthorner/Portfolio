using System.Linq;
using System.Web.Mvc;

namespace PresentationEpiserver.Classes
{
    public class CustomViewEngine : RazorViewEngine
    {
        private readonly string[] _pageLocations = 
        {
            "~/Views/Pages/{1}/{0}.cshtml"
        };

        private readonly string[] _blockLocations =
        {
            "~/Views/Blocks/{1}/{0}.cshtml",
        };

        public CustomViewEngine()
        {
            PartialViewLocationFormats = PartialViewLocationFormats.Union(_blockLocations).ToArray();
            ViewLocationFormats = ViewLocationFormats.Union(_pageLocations).ToArray();
        }
    }
}