using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cloudnine.Models.Blocks;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace cloudnine.Controllers
{
    public class BloggFeedController : BlockController<BloggFeed>
    {
        public override ActionResult Index(BloggFeed currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
