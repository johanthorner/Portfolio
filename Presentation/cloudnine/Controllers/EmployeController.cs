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
    public class EmployeController : BlockController<Employe>
    {
        public override ActionResult Index(Employe currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
