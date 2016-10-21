using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace cloudnine.Models.Pages
{
    [ContentType(DisplayName = "CasePage", GUID = "e27944c6-8bb9-485b-8f92-cf4eada6edb7", Description = "")]
    public class CasePage : SitePageData
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
           Name = "Columns in Bootstrap",
           Description = "Enter the number of collumns the case vil have on the cases page",
           GroupName = SystemTabNames.Content,
           Order = 2)]
        public virtual int BootstrapColumns { get; set; }


        [CultureSpecific]
        [Display(
          Name = "Image",
          Description = "Place Image here.",
          GroupName = SystemTabNames.Content,
          Order = 2)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [CultureSpecific]
        [Display(
         Name = "Case Presentation Image",
         Description = "Place Image here.",
         GroupName = SystemTabNames.Content,
         Order = 2)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference CasePresentationImage { get; set; }
    }
}