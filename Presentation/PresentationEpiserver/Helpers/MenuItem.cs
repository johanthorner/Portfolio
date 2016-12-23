using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PresentationEpiserver.Models.Pages;

namespace PresentationEpiserver.Helpers
{
    public class MenuItem
    {
        public SitePageData SitePageData { get; set; }
        public bool Active { get; set; }
        public bool IsBloggPage { get; set; }
    }
}