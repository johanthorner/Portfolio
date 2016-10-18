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
    public class ContactMeFormController : BlockController<ContactMeForm>
    {
        public override ActionResult Index(ContactMeForm currentBlock)
        {
            return PartialView(currentBlock);
        }
        
    }
}
