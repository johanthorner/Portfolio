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
    public class ImageSliderController : BlockController<ImageSlider>
    {
        public override ActionResult Index(ImageSlider currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
