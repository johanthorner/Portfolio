using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "ImageSlider", GUID = "8c94d39d-7d87-48de-aee8-dddbe4491fc3", Description = "")]
    public class ImageSlider : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Name { get; set; }

        [CultureSpecific]
        [Display(
         Name = "Images",
         Description = "Place image blocks here",
         GroupName = SystemTabNames.Content,
         Order = 20)]
        public virtual ContentArea Images { get; set; }


    }
}