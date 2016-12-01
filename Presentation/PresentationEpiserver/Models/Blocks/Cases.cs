using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "Cases", GUID = "2355a770-f9c7-48ab-9822-c2d255f08881", Description = "")]
    public class Cases : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Presentation text",
            Description = "A short description about the content.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString Text { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Header",
            Description = "Presented ass a header above the text and the cases.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString Header { get; set; }

    }
}