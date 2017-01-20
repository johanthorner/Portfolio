using System.Web.Mvc;
using EPiServer.Web.Mvc;
using PresentationEpiserver.Models.Blocks;

namespace PresentationEpiserver.Controllers
{
    public class TextBlockCenteredCollumnController : BlockController<TextBlockCenteredCollumn>
    {
        public override ActionResult Index(TextBlockCenteredCollumn currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
