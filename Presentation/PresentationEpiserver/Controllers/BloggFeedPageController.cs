using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Castle.Core.Internal;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;
using PresentationEpiserver.Models.Pages;
using PresentationEpiserver.Models.ViewModels;
using PresentationEpiserver.Utilities;

namespace PresentationEpiserver.Controllers
{
    public class BloggFeedPageController : PageController<BloggFeedPage>
    {
        private readonly BlogUtilities _blogUtilities;
        private readonly UrlResolver _urlResolver;

        public BloggFeedPageController(BlogUtilities blogUtilities, UrlResolver urlResolver)
        {
            _blogUtilities = blogUtilities;
            _urlResolver = urlResolver;
        }

        public ActionResult Index(BloggFeedPage currentPage, int p = 1, string searchString = "")
        {
            int pageSize = currentPage.NumberOfBloggsPerPage;
            var bloggs = _blogUtilities.GetAllBlogPages().ToList();
            var pageUrl = _urlResolver.GetVirtualPath(currentPage.ContentLink);

            var totalBloggs = bloggs.Count;
            List<BloggPage> sortedBloggs = new List<BloggPage>();

            if (!searchString.IsNullOrEmpty())
            {
                sortedBloggs =
                    bloggs.Where(b => b.Text.ToString().Contains(searchString))
                        .Skip((p - 1)*pageSize)
                        .Take(pageSize)
                        .ToList();
            }
            else
            {
                sortedBloggs = bloggs.Skip((p - 1) * pageSize).Take(pageSize).ToList();
            }
            var paginationViewModel = new PaginationViewModel(p, pageSize, sortedBloggs.Count);
            
            var model = new BloggListPageViewModel()
            {
                Selected = p,
                BloggIntroText = currentPage.BloggIntroText,
                ButtonText = currentPage.ButtonText,
                Bloggs = sortedBloggs,
                PaginationViewModel = paginationViewModel,
                UrlResolver = pageUrl,
                ContentReference =  currentPage.ContentLink,
                LastSearch = searchString,
               
            };
            if (!searchString.IsNullOrEmpty())
            {
                model.LastPostWasSearch = true;
            }
            return View(model);
        }
    }
}