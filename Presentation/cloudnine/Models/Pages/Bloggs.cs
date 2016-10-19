using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace cloudnine.Models.Pages
{
    [ContentType(DisplayName = "Bloggs", GUID = "5a62d246-238d-479d-b604-bc7b02f85f51", Description = "")]
    public class Bloggs : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Text for blogg",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Content area for blogg feed",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual ContentArea ContentAreaForBloggFreed { get; set; }

     

    }
}