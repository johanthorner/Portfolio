using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "SocialMediaLinkBlock", GUID = "18891ac1-83a4-44c2-b2da-b06488a66524", Description = "")]
    public class SocialMediaLinkBlock : BlockData
    {
        [Display(Name = "Link To Social media",
        GroupName = SystemTabNames.Content,
        Order = 10)]
        public virtual LinkItemCollection Link { get; set; }


        [UIHint(UIHint.Image)]
        [Display(Name = "Social Media Logo",
             Description = "Place the image-file here",
             GroupName = SystemTabNames.Content)]
        public virtual ContentReference SocialMediaLogo { get; set; }
    }
}