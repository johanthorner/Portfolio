using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "TextBlockCenteredCollumn", GUID = "9d2e05a8-f3eb-4904-a29a-2806788c9f4f", Description = "")]
    public class TextBlockCenteredCollumn : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Header",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Text",
            Description = "Main text",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString Text { get; set; }

    }
}