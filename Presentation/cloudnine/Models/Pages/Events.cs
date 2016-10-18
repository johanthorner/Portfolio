using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace cloudnine.Models.Pages
{
    [ContentType(DisplayName = "Events", GUID = "97f8a0f3-7aea-4799-9307-7d8fa2c2cb0b", Description = "")]
    public class Events : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Title Page",
            Description = "The title of the page",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

    }
}