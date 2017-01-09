using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "FooterColumnLinkBlock", GUID = "ce8f448d-9ed3-4392-aabf-30cebcc88034", Description = "")]
    public class FooterColumnLinkBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Link Url",
            Description = "Link to a external page",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string LinkUrl { get; set; }


        [CultureSpecific]
        [Display(
            Name = "Link text",
            Description = "Link to a external page",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string LinkText { get; set; }

    }
}