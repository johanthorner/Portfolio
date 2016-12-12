using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using PresentationEpiserver.Models.Blocks;
using PresentationEpiserver.Models.Pages;
using PresentationEpiserver.Models.ViewModels;

namespace PresentationEpiserver.Controllers
{
    public class BloggBlockController : BlockController<BloggBlock>
    {
        public override ActionResult Index(BloggBlock currentBlock)
        {
            int p = 1;
            int pageSize = 3;

            var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();
            var startPage = contentLoader.Get<StartPage>(ContentReference.StartPage);
            var bloggs = contentLoader.GetChildren<BloggPage>(startPage.BloggRoot).ToList();
            var totalBloggs = bloggs.Count;

            var sortedBloggs = bloggs.Skip((p - 1) * pageSize).Take(pageSize).ToList();
           
            var paginationViewModel = new PaginationViewModel(p, pageSize, totalBloggs);
     
            var model = new BloggListPageViewModel()
            {
                BloggIntroText = currentBlock.BloggIntroText,
                ButtonText = currentBlock.ButtonText,
                Bloggs = sortedBloggs,
                PaginationViewModel = paginationViewModel
            };
            
            return PartialView(model);
        }

    }
}
