using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace cloudnine.Models.Blocks
{
    [ContentType(DisplayName = "JobbFeed", GUID = "9ade515d-d854-4ec4-b7f5-a60d71dcab66", Description = "")]
    public class JobbFeed : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Jobb feed",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string JobbFeedName { get; set; }

    }
}