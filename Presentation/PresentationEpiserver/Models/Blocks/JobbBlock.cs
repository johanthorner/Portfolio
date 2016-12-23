using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "JobbBlock", GUID = "0e679434-37f7-47ed-88be-135235fd5f82", Description = "")]
    public class JobbBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "The title/ header for the add.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Text",
          Description = "The description text for the add.",
          GroupName = SystemTabNames.Content,
          Order = 20)]
        public virtual XhtmlString Text { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Link",
           Description = "The link to the site.",
           GroupName = SystemTabNames.Content,
           Order = 30)]
        public virtual string Link { get; set; }

    }
}