using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.ServiceLocation;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace PresentationEpiserver.Models.Blocks
{
    public class SelectMainCategory : ISelectionFactory

    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return LoadItems();
        }
        private IEnumerable<SelectItem> LoadItems()
        {
            var contentTypeRepository = ServiceLocator.Current.GetInstance<IContentTypeRepository>();
            var contentModelUsage = ServiceLocator.Current.GetInstance<IContentModelUsage>();
            var mainCategoryblockType = contentTypeRepository.Load<MainCategoryBlock>();
            var mainCategoryblock = contentModelUsage.ListContentOfContentType(mainCategoryblockType);

            var items = new Dictionary<string, string>{};
            foreach (var mainCategory in mainCategoryblock)
            {
               
                     items.Add(mainCategory.ContentLink.ID.ToString(), mainCategory.Name.ToString());
            }
           
            return items.Select(item => new SelectItem { Text = item.Value, Value = item.Key });
        }

    }
}