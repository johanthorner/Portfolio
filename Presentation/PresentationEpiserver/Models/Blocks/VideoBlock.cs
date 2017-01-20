using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "VideoBlock", GUID = "66f7ad3a-9924-4abb-bb01-e0c55d179a94", Description = "")]
    public class VideoBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Header",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Header { get; set; }

    }
}