using System;
using System.Collections.Generic;
using System.Linq;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace PresentationEpiserver.Classes
{
    public class ImageTintTransparencySelection : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return LoadItems();
        }
        private IEnumerable<SelectItem> LoadItems()
        {
            var items = new Dictionary<string, string>
            {
                {"0", "100%"},
                {"0.2", "75%"},
                {"0.5", "50%"},
                {"0.7", "25%"},
                {"1", "0%"}
            };
            return items.Select(item => new SelectItem { Text = item.Value, Value = item.Key });
        }
    }
    [EditorDescriptorRegistration(TargetType = typeof(string), UIHint = "ImageTransparency")]
    public class ImageTintTransparencySelectionEditorSelector : EditorDescriptor
    {
        public override void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            SelectionFactoryType = typeof(NumberOfCollumns);
            ClientEditingClass = "epi-cms/contentediting/editors/SelectionEditor"; base.ModifyMetadata(metadata, attributes);
        }
    }
}