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
    public class CasesController : BlockController<Cases>
    {
        public override ActionResult Index(Cases currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
