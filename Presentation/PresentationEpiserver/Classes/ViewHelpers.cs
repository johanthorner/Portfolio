using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using PresentationEpiserver.Models.Pages;

namespace PresentationEpiserver.Classes
{
    public static class ViewHelpers
    {
        public static List<CasePage> GetCasePages(this HtmlHelper helper)
        {
            var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();
            var startpage = contentLoader.Get<StartPage>(ContentReference.StartPage);
            return contentLoader.GetChildren<CasePage>(startpage.CaseRoot).ToList();
        }
    }
}