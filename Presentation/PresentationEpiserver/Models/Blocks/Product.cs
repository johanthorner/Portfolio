using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "Product", GUID = "7654b9cf-4cf8-4e74-9044-3f648d4a52d4", Description = "")]
    public class Product : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Name { get; set; }

        [SelectOne(SelectionFactoryType = typeof(SelectSubCategory))]
        [UIHint("SubCategory")]
        [Display(
           Name = "Sett Sub Category",
           Order = 20)]
        [CultureSpecific]
        public virtual string SubCategory { get; set; }
    }
}