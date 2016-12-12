using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace PresentationEpiserver.Models.Pages
{
    [ContentType(DisplayName = "bloggPage", GUID = "00e834d1-035a-4e56-9524-ca0c16e2598c", Description = "")]
    public class BloggPage : BasePage
    {

        [CultureSpecific]
        [Display(
            Name = "Header",
            Description = "Blogg header",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual XhtmlString Header { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Ingress",
            Description = "Ingress will shown in the blogg-block.",
            GroupName = SystemTabNames.Content,
            Order = 15)]
        public virtual XhtmlString ingress { get; set; }


        [CultureSpecific]
        [Display(
            Name = "Text",
            Description = "Blogg text",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString Text { get; set; }

        [UIHint(UIHint.Image)]
        [Display(Name = "Blogg Image",
          Description = "A image to be placed on the page.",
          GroupName = Groups.GroupNames.CasePresentationPropertys,
          Order = 30)]
        public virtual ContentReference Image { get; set; }

    }
}