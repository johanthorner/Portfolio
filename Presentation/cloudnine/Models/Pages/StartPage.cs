using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace cloudnine.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "1c0dfaf4-3cb7-4b77-966f-c1bb7c89ba59", Description = "")]
    public class StartPage : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Title Page",
            Description = "Sidans titel",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Presentation Cases",
            Description = "A Short text about the cases.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Cases",
            Description = "Place Case presnetations here.",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual ContentArea Blogs { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Customers",
            Description = "Customers",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual ContentArea Customers { get; set; }

    }
}