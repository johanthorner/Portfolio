using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EPiServer;
using EPiServer.AddOns.Helpers;
using EPiServer.Core;
using EPiServer.Core.Html;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;
using PresentationEpiserver.Models;
using PresentationEpiserver.Models.Pages;
using PresentationEpiserver.Utilities;

namespace PresentationEpiserver.Controllers.api
{

    public class BloggsController : ApiController
    {
        private readonly BlogUtilities _blogUtilities;
        private readonly UrlResolver _urlResolver;
        
        public BloggsController(BlogUtilities blogUtilities, UrlResolver urlResolver)
        {
            _blogUtilities = blogUtilities;
            _urlResolver = urlResolver;

        }
        public IHttpActionResult Get(string lang = "", int numberOfArticles = 4)
        {
            var data = _blogUtilities.GetAllBlogPages(lang).Select(b => new Blogg
            {
                Header = b.Header != null ? TextIndexer.StripHtml(b.Header.ToHtmlString(), int.MaxValue) : string.Empty,
                ID = b.ContentLink.ID,
                Ingress = b.ingress != null ? TextIndexer.StripHtml(b.ingress.ToHtmlString(), int.MaxValue) : string.Empty,
                CultureInfo = b.Language,
                ImageUrl = b.Image.GetPublicUrl()


            }).ToList().Take(numberOfArticles);

            return Ok(data);
        }
    }
}
