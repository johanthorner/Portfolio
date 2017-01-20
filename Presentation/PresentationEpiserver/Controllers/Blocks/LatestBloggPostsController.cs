using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using PresentationEpiserver.Models.Blocks;

namespace PresentationEpiserver.Controllers
{
    public class LatestBloggPostsController : BlockController<LatestBloggPosts>
    {
        public override ActionResult Index(LatestBloggPosts currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
