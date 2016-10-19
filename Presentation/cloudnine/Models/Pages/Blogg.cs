using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace cloudnine.Models.Pages
{
    [ContentType(DisplayName = "Blogg", GUID = "f8bd0706-9503-49f3-8629-f1d99291682c", Description = "")]
    public class Blogg : SitePageData
    {
        [CultureSpecific]
        [Display(
              Name = "Headline",
              Description = "Headline for the blogg.",
              GroupName = SystemTabNames.Content,
              Order = 2)]
        public virtual string Headline { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Text",
            Description = "The main text of the blogg.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainText { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Image",
          Description = "Place Image here.",
          GroupName = SystemTabNames.Content,
          Order = 2)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }


    }
}