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
    public class JobbBlockController : BlockController<JobbBlock>
    {
        public override ActionResult Index(JobbBlock currentBlock)
        {
            ViewData["LinkText"] = ControllerContext.ParentActionViewContext.ViewData["LinkText"];

            return PartialView(currentBlock);
        }
    }
}
