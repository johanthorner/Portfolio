using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace cloudnine.Models.Pages
{
    [ContentType(DisplayName = "Services", GUID = "1f8b92f5-bcb8-4f78-98b2-df0cb2bcb992", Description = "")]
    public class Services : SitePageData
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