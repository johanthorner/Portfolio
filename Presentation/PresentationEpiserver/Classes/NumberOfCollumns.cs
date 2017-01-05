using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace PresentationEpiserver.Classes
{
    public class NumberOfCollumns : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return LoadItems();
        }
        private IEnumerable<SelectItem> LoadItems()
        {
            var items = new Dictionary<string, string>
            {
                {"col-lg-4 col-md-6 col-sm-12", "1/3"},
                {"col-lg-6 col-md-12 col-sm-12", "1/2"},
                {"col-lg-12 col-md-12 col-sm-12", "1"}
            };
            return items.Select(item => new SelectItem { Text = item.Value, Value = item.Key });
        }
    }
    [EditorDescriptorRegistration(TargetType = typeof(string), UIHint = "NumberOfCollumns")]
    public class ImageHeightSelectionEditorSelector : EditorDescriptor
    {
        public override void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            SelectionFactoryType = typeof(NumberOfCollumns);
            ClientEditingClass = "epi-cms/contentediting/editors/SelectionEditor"; base.ModifyMetadata(metadata, attributes);
        }
    }


}