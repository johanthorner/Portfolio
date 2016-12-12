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

namespace PresentationEpiserver.Controllers
{
    public class ContactBlockController : BlockController<ContactBlock>
    {
        public override ActionResult Index(ContactBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
