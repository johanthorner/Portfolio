using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace PresentationEpiserver.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "8920e26f-c50a-4c61-9e97-98182226b85f", Description = "")]
    public class StartPage : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
        Name = "Start Root",
        Description = "",
        GroupName = SystemTabNames.Content,
        Order = 20)]
        public virtual ContentReference StartRoot { get; set; }

    }
}