using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
        public static List<SitePageData> GetAllCases(this HtmlHelper helper)
        {
            var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();
            var startPage = contentLoader.Get<StartPage>(ContentReference.StartPage);
            
            return contentLoader.GetChildren<SitePageData>(startPage.CaseRoot).ToList();

        }

        public static List<SitePageData> GetSubMenuItems(SitePageData currentPage)
        {
          
            var contentloader = ServiceLocator.Current.GetInstance<IContentLoader>();

            //ContentReference reference = currentPage.ContentLink;
            return contentloader.GetChildren<SitePageData>(currentPage.ContentLink).ToList();
        }
      
    }
}