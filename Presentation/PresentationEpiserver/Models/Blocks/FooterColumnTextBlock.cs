using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "FooterColumnTextBlock", GUID = "1f9e2ee9-a1f4-4574-a74c-f06beacbf765", Description = "")]
    public class FooterColumnTextBlock :  FooterColumnBaseBlock
    {

        [CultureSpecific]
        [Display(
            Name = "Text",
            Description = "Place text here",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Text { get; set; }

    }

    public class FooterColumnBaseBlock : BlockData
    {
        
    }
}