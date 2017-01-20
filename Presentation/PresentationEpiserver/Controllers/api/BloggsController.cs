using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EPiServer;
using EPiServer.AddOns.Helpers;
using EPiServer.Cms.Shell;
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
        [AcceptVerbs("GET")]
        public IHttpActionResult Get(string lang = "", int numberOfArticles = 4)
        {
            var data = _blogUtilities.GetAllBlogPages(lang).Select(b => new Blogg
            {
                Header = b.Header != null ? TextIndexer.StripHtml(b.Header.ToHtmlString(), int.MaxValue) : string.Empty,
                ID = b.ContentLink.ID,
                Ingress = b.ingress != null ? TextIndexer.StripHtml(b.ingress.ToHtmlString(), int.MaxValue) : string.Empty,
                CultureInfo = b.Language,
                ImageUrl = b.Image.GetPublicUrl(),
                BloggPageUrl = b.ContentLink.GetPublicUrl()

            }).ToList().Take(numberOfArticles);

            return Ok(data);
        }
        [AcceptVerbs("GET")]
        public IHttpActionResult Menu(string lang = "", int numberOfArticles = 4)
        {
            var bloggData = _blogUtilities.GetAllBlogPages(lang).Select(b => new Blogg
            {
                Header = b.Header != null ? TextIndexer.StripHtml(b.Header.ToHtmlString(), int.MaxValue) : string.Empty,
                ID = b.ContentLink.ID,
                CultureInfo = b.Language,
                BloggPageUrl = b.ContentLink.GetPublicUrl(),
                Changed = b.Changed

            }).ToList();

            IndexModel indexModel = new IndexModel(bloggData);

            var data = indexModel;
            return Ok(data);
        }
    }

    public class IndexModel
    {
        public List<IndexModelYear> Years { get; set; }

        public IndexModel(List<Blogg> bloggs)
        {
            Years = new List<IndexModelYear>();
               
            for (int i = 0; i <= bloggs.Count - 1; i++)
            {
                if (i == 0)
                {
                    Years.Add(new IndexModelYear(bloggs[i].Changed.Year, bloggs));
                }
                else if (bloggs[i].Changed.Year != bloggs[i - 1].Changed.Year)
                {
                    Years.Add(new IndexModelYear(bloggs[i].Changed.Year, bloggs));
                }
            }
        }
    }

    public class IndexModelYear
    {
        public int Year { get; set; }
        public List<IndexModelBlogg> Bloggs { get; set; }

        public IndexModelYear(int year, List<Blogg> bloggs)
        {
            Year = year;
            Bloggs = new List<IndexModelBlogg>();
            foreach (var blogg in bloggs)
            {
                if (Convert.ToInt32(blogg.Changed.Year) == Year)
                {
                    Bloggs.Add(new IndexModelBlogg() {Year = blogg.Changed.Year.ToString(), Header = blogg.Header, BlogUrl = blogg.BloggPageUrl});
                }
            }
        }
    }

    public class IndexModelBlogg
    {
        public string Header { get; set; }
        public string Year { get; set; }

        public string BlogUrl { get; set; }
    
        public IndexModelBlogg()
        {
            
        }
    }
}
