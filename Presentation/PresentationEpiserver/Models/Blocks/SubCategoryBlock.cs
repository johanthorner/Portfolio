using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "SubCategoryBlock", GUID = "e7e9f1f9-52a7-43d4-af22-255401d3efbe", Description = "")]
    public class SubCategoryBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Name { get; set; }

        [SelectOne(SelectionFactoryType = typeof(SelectMainCategory))]
        [UIHint("MainCategory")]
        [Display(
            Name = "Main Category",
            Order = 20)]
        [CultureSpecific]
        public virtual string mainCategory { get; set; }


    }
}