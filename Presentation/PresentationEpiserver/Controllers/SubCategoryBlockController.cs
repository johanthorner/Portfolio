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
    public class SubCategoryBlockController : BlockController<SubCategoryBlock>
    {
        public override ActionResult Index(SubCategoryBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
