using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "SmallBlogFeed", GUID = "22780180-ae46-4e6d-8a20-f50d5062e792", Description = "")]
    public class SmallBlogFeed : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Header",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Header { get; set; }

    }
}