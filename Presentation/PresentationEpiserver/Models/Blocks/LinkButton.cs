using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "LinkButton", GUID = "1eb7ad3c-f60c-4e07-80e5-7e56f3df7a1d", Description = "")]
    public class LinkButton : BlockData
    {
        [CultureSpecific]
        [Display(
           Name = "Link to page on this site",
           Description = "Presented as a button in the center of the page.",
           GroupName = SystemTabNames.Content,
           Order = 10)]
        public virtual PageReference LinkToPage { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Url to another site",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string LinkToExternalPage { get; set; }

        [CultureSpecific]
        [Display(
         Name = "Link text",
         GroupName = SystemTabNames.Content,
         Order = 30)]
        public virtual string LinkText { get; set; }
    }
}