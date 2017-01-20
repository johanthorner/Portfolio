using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Castle.Components.DictionaryAdapter;
using Castle.Core.Internal;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;
using PresentationEpiserver.Models;
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

        public ActionResult Index(BloggFeedPage currentPage, int p = 1, string searchString = "", int month = 13)
        {
            int pageSize = currentPage.NumberOfBloggsPerPage;
            var bloggs = _blogUtilities.GetAllBlogPages().ToList();
            var pageUrl = _urlResolver.GetVirtualPath(currentPage.ContentLink);

            var paginationViewModel = new PaginationViewModel(p, pageSize, bloggs.Count);

            List<BloggPage> selectedBloggs = new List<BloggPage>();
            List<BloggPage> bloggsToModel = new List<BloggPage>();

            IndexViewModel indexViewModel = new IndexViewModel(bloggs);
            
            if (!searchString.IsNullOrEmpty() || month != 13)
            {
                if (!searchString.IsNullOrEmpty())
                {
                    selectedBloggs = bloggs.Where(b => b.Text.ToString().ToLower().Contains(searchString.ToLower())).ToList();
                    bloggsToModel = selectedBloggs.Skip((p - 1) * pageSize).Take(pageSize).ToList();
                    paginationViewModel = new PaginationViewModel(p, pageSize, selectedBloggs.Count);
                }
                else
                {
                    selectedBloggs = bloggs.Where(b => b.Changed.Month == month).ToList();
                    bloggsToModel = selectedBloggs.Skip((p - 1) * pageSize).Take(pageSize).ToList();
                    paginationViewModel = new PaginationViewModel(p, pageSize, selectedBloggs.Count);
                }
            }
            else
            {
                bloggsToModel = bloggs.Skip((p - 1) * pageSize).Take(pageSize).ToList();
            }

            var model = new BloggListPageViewModel()
            {
                Selected = p,
                BloggIntroText = currentPage.BloggIntroText,
                ButtonText = currentPage.ButtonText,
                Bloggs = bloggsToModel,
                PaginationViewModel = paginationViewModel,
                UrlResolver = pageUrl,
                ContentReference = currentPage.ContentLink,
                LastSearch = searchString,
                Month = month,
                NumberOfBloggsFound = selectedBloggs.Count,
                SearchBoxPlaceHolder = currentPage.SearchBoxPlaceHolder,
                SearchResultText = currentPage.SearchResultText,
                IndexViewModel = indexViewModel
            };
            if (!searchString.IsNullOrEmpty())
            {
                model.LastPostWasSearch = true;
            }
            return View(model);
        }
    }

    public class IndexViewModel
    {
        public List<IndexViewModelYear> Years { get; set; }

        public IndexViewModel(List<BloggPage> bloggs)
        {
            Years = new List<IndexViewModelYear>();
            for (int i = 0; i <= bloggs.Count - 1; i++)
            {
                if (i == 0)
                {
                    Years.Add(new IndexViewModelYear() { Year = bloggs[i].Changed.Year });
                }
                else if (bloggs[i].Changed.Year != bloggs[i - 1].Changed.Year)
                {
                    Years.Add(new IndexViewModelYear() { Year = bloggs[i].Changed.Year });
                }
            }
        }
    }

    public class IndexViewModelYear
    {
        public int Year { get; set; }
        public List<IndexViewModelMonth> Months { get; set; }
        public IndexViewModelYear()
        {
            Months = new List<IndexViewModelMonth>();
        }
    }

    public class IndexViewModelMonth
    {
        public int Month { get; set; }
        public List<IndexViewModelBlogg> Bloggs { get; set; }
    }

    public class IndexViewModelBlogg
    {
        
    }
}
