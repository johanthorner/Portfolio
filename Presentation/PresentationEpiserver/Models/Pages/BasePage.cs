using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace PresentationEpiserver.Models.Pages
{
    [ContentType(DisplayName = "BasePage", GUID = "0ea39212-1379-4f9a-8a08-f3478ad6f17b", Description = "")]
    public class BasePage : SitePageData
    {
        [CultureSpecific]
        [Display(
           Name = "Page title",
           Description = "",
           GroupName = SystemTabNames.Content,
           Order = 1)]
        public virtual string PageTitle { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Place page blocks here.",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual ContentArea PageContent { get; set; }

    }
}