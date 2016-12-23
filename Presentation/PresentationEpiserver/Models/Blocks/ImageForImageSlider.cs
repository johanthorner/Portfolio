using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "ImageForImageSlider", GUID = "2be5e08d-54b7-4ee3-b56f-38c271828128", Description = "")]
    public class ImageForImageSlider : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Title for the image",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Name { get; set; }

        [UIHint(UIHint.Image)]
        [Display(Name = "Image",
            Description = "Place the image-file here",
            GroupName = SystemTabNames.Content)]
        public virtual ContentReference Image { get; set; }

    }
}