﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;
using PresentationEpiserver.Models.Pages;
using PresentationEpiserver.Models.ViewModels;

namespace PresentationEpiserver.Controllers
{
    public class BloggFeedPageController : PageController<BloggFeedPage>
    {
        public ActionResult Index(BloggFeedPage currentPage, int p = 1)
        {
            int pageSize = currentPage.NumberOfBloggsPerPage;

            var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();
            var startPage = contentLoader.Get<StartPage>(ContentReference.StartPage);
            var bloggs = contentLoader.GetChildren<BloggPage>(startPage.BloggRoot).ToList();

            var urlResolver = ServiceLocator.Current.GetInstance<UrlResolver>();
            var pageUrl = urlResolver.GetVirtualPath(currentPage.ContentLink);

            var totalBloggs = bloggs.Count;

            var sortedBloggs = bloggs.Skip((p - 1) * pageSize).Take(pageSize).ToList();

            var paginationViewModel = new PaginationViewModel(p, pageSize, totalBloggs);
            
            var model = new BloggListPageViewModel()
            {
                Selected = p,
                BloggIntroText = currentPage.BloggIntroText,
                ButtonText = currentPage.ButtonText,
                Bloggs = sortedBloggs,
                PaginationViewModel = paginationViewModel,
                UrlResolver = pageUrl,
                ContentReference =  currentPage.ContentLink
            };

            return View(model);
        }
    }
}