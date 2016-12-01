using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace PresentationEpiserver.Models.Blocks
{
    [EditorDescriptorRegistration(TargetType = typeof(string), UIHint = "ImageHeight")]

    public class SelectSubCategoryEditorSelector : EditorDescriptor
    {
        public override void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            SelectionFactoryType = typeof(SelectSubCategory);
            ClientEditingClass = "epi-cms/contentediting/editors/SelectionEditor"; base.ModifyMetadata(metadata, attributes);
        }

    }
}