using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "FooterColumnBlock", GUID = "94f16c98-f29d-4506-a2f5-627dd728fe80", Description = "")]
    public class FooterColumnBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Content",
            Description = "Place the content of the column here",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [AllowedTypes(new[] { typeof(FooterColumnTextBlock), typeof(FooterColumnLinkBlock) })]
        public virtual ContentArea Content { get; set; }

    }
}