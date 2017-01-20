using System.Web.Mvc;
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
