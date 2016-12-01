using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "TextBlockBig", GUID = "f8ada5d1-168d-4a58-9075-2516e9fc7206", Description = "")]
    public class TextBlockBig : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Main text",
            Description = "Provides a text area that that stretches the full width of the screen.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString Text { get; set; }

    }
}