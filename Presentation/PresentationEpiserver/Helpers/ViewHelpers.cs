using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.ServiceLocation;
using EPiServer.Shell.Navigation;
using EPiServer.Web.Routing;
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

        public static List<BloggPage> GetBloggs(this HtmlHelper helper)
        {
            var contentloader = ServiceLocator.Current.GetInstance<IContentLoader>();
            var startPage = contentloader.Get<StartPage>(ContentReference.StartPage);
            return contentloader.GetChildren<BloggPage>(startPage.BloggRoot).ToList();
        }

        public static List<CasePage> GetCasePages(this HtmlHelper helper)
        {
            var contentloader = ServiceLocator.Current.GetInstance<IContentLoader>();
            var startPage = contentloader.Get<StartPage>(ContentReference.StartPage);
            return contentloader.GetChildren<CasePage>(startPage.CaseRoot).ToList();
        }

        public static List<MenuItem> GetMenuItems(this HtmlHelper helper)
        {
            var contentloader = ServiceLocator.Current.GetInstance<IContentLoader>();
            var pageRouteHelper = ServiceLocator.Current.GetInstance<IPageRouteHelper>();

            var subSites = contentloader.GetChildren<SitePageData>(ContentReference.StartPage);
            var menuItems = new List<MenuItem>();

            foreach (var child  in subSites)
            {
                menuItems.Add(new MenuItem
                {
                    SitePageData = child,
                    Active = PageHasSameId(pageRouteHelper.Content.ContentLink, child.ContentLink),
                    IsBloggPage = IsBloggPage(child)
                });
            }
            
            return menuItems;
        }

        private static bool PageHasSameId(ContentReference a, ContentReference b)
        {
            return !ContentReference.IsNullOrEmpty(a) && !ContentReference.IsNullOrEmpty(b) && a.ID == b.ID;
        }

        private static bool IsBloggPage(SitePageData child)
        {
            if (child.PageTypeName == "BloggFeedPage")
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }
      
    }
}


