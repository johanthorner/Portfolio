using System.Web.Mvc;
using EPiServer.Web.Mvc;
using PresentationEpiserver.Models.Blocks;

namespace PresentationEpiserver.Controllers
{
    public class VideoBlockController : BlockController<VideoBlock>
    {
        public override ActionResult Index(VideoBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
