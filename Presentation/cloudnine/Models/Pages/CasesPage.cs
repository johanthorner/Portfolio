using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace cloudnine.Models.Pages
{
    [ContentType(DisplayName = "Cases", GUID = "519b8e25-4432-47fc-97e3-ab793dd77f07", Description = "")]
    public class CasesPage : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
        Name = "Cases Area",
        Description = "Customers",
        GroupName = SystemTabNames.Content,
        Order = 2)]
        public virtual ContentArea CasesArea { get; set; }

    }
}