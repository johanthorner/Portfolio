using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.ServiceLocation;
using EPiServer.Shell.ObjectEditing;

namespace PresentationEpiserver.Models.Blocks
{
    public class SelectSubCategory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return LoadItems();
        }
        private IEnumerable<SelectItem> LoadItems()
        {
            var contentTypeRepository = ServiceLocator.Current.GetInstance<IContentTypeRepository>();
            var contentModelUsage = ServiceLocator.Current.GetInstance<IContentModelUsage>();
            var subCategoryblockType = contentTypeRepository.Load<SubCategoryBlock>();
            var subCategoryblock = contentModelUsage.ListContentOfContentType(subCategoryblockType);

            var items = new Dictionary<string, string> { };
            foreach (var mainCategory in subCategoryblock)
            {

                items.Add(mainCategory.ContentLink.ToString(), mainCategory.Name);
            }

            return items.Select(item => new SelectItem { Text = item.Value, Value = item.Key });
        }
    }
}