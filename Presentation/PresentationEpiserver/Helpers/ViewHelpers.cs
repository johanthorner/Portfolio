using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.ServiceLocation;
using PresentationEpiserver.Models.Pages;

namespace PresentationEpiserver.Helpers
{
    public static class ViewHelpers
    {
        public static List<SitePageData> GetMenuItems(bool includeStartPage)
        {
            var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();
            var toppLevelPages = contentLoader.GetChildren<SitePageData>(ContentReference.StartPage).ToList();

            var rootLink = contentLoader.Get<SitePageData>(ContentReference.StartPage);

            toppLevelPages = FilterForVisitor.Filter(toppLevelPages).OfType<SitePageData>().Where(x => x.VisibleInMenu).ToList();

            if (includeStartPage)
            {
                toppLevelPages.Insert(0, rootLink);
            }
            return toppLevelPages;

        }
        public static List<SitePageData> GetSubMenuItems(this HtmlHelper helper)
        {

            var contentloader = ServiceLocator.Current.GetInstance<IContentLoader>();

            var startPage = contentloader.Get<StartPage>(ContentReference.StartPage);

            
            return contentloader.GetChildren<SitePageData>(startPage.StartRoot).ToList();

        }

    }
}