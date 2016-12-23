using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "Image Large", GUID = "dc278f19-f324-461b-8e7d-f382568a756c", Description = "")]
    public class ImageLarge : BlockData
    {
        [UIHint(UIHint.Image)]
        [Display(Name = "Image",
             Description = "Place the image-file here",
             GroupName = SystemTabNames.Content)]
        public virtual ContentReference Image { get; set; }

    }
}