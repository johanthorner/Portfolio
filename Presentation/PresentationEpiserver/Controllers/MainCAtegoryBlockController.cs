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
    public class MainCategoryBlockController : BlockController<MainCategoryBlock>
    {
        public override ActionResult Index(MainCategoryBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
