using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "BloggBlock", GUID = "5f776beb-23cf-466c-8614-983e0e803b73", Description = "")]
    public class BloggBlock : BlockData
    {
        [CultureSpecific]
        [Display(
         Name = "Blogg Intro Text",
         Description = "A short description about the content.",
         GroupName = SystemTabNames.Content,
         Order = 1)]
        public virtual XhtmlString BloggIntroText { get; set; }

        [CultureSpecific]
        [Display(
        Name = "Button Text",
        Description = "A short description about the content.",
        GroupName = SystemTabNames.Content,
        Order = 1)]
        public virtual string ButtonText { get; set; }
    }
}