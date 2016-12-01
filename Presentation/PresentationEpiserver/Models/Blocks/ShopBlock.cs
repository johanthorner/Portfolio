using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "ShopBlock", GUID = "246fabb0-200e-4a2f-877f-a2ae3ef6d632", Description = "")]
    public class ShopBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "ShopBlock",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Name { get; set; }

        [CultureSpecific]
        [Display(
            Name = "MainCategoryArea",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        [AllowedTypes(new[] { typeof(MainCategoryBlock) })]
        public virtual ContentArea MainCategoryArea { get; set; }

        [CultureSpecific]
        [Display(
           Name = "SubCategoryArea",
           Description = "Name field's description",
           GroupName = SystemTabNames.Content,
           Order = 30)]
        [AllowedTypes(new[] { typeof(SubCategoryBlock) })]
        public virtual ContentArea SubCategoryArea { get; set; }

        [CultureSpecific]
        [Display(
           Name = "DisplayProductListArea",
           Description = "Name field's description",
           GroupName = SystemTabNames.Content,
           Order = 40)]
        [AllowedTypes(new[] { typeof(Product) })]
        public virtual ContentArea DisplayProductListArea { get; set; }

    }
}