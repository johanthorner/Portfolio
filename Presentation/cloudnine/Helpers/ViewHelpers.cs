using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using cloudnine.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;

namespace cloudnine.Helpers
{
    public static class ViewHelpers
    {
        public static List<SitePageData> GetMenuItems()
        {
            var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();
            return contentLoader.GetChildren<SitePageData>(ContentReference.StartPage).ToList();

        }
    }
}