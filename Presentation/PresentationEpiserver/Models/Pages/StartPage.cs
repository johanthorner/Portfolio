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

        [CultureSpecific]
        [Display(
           Name = "Start Root",
           Description = "",
           GroupName = SystemTabNames.Content,
           Order = 25)]
        public virtual ContentReference CaseRoot { get; set; }

        [Display(
            Name = "Address",
            Description = "Presents a link to google maps",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual string Address { get; set; }


        [Display(
            Name = "Mail",
            Description = "Presents the post adress as text",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        public virtual string Mail { get; set; }

        [Display(
            Name = "Contact",
            Description = "Presents the post adress as text",
            GroupName = SystemTabNames.Content,
            Order = 50)]
        public virtual string Contact { get; set; }

        [Display(
            Name = "AdditionalInfo",
            Description = "Additional information",
            GroupName = SystemTabNames.Content,
            Order = 60)]
        public virtual string AdditionalInfo { get; set; }

        [Display(
            Name = "Twitter Link",
            Description = "Additional information",
            GroupName = SystemTabNames.Content,
            Order = 70)]
        public virtual string TwitterLink { get; set; }

        [Display(
            Name = "Facebook link",
            Description = "Additional information",
            GroupName = SystemTabNames.Content,
            Order = 80)]
        public virtual string FacebookLink { get; set; }

        [Display(
            Name = "Linkedin link",
            Description = "Additional information",
            GroupName = SystemTabNames.Content,
            Order = 90)]
        public virtual string LinkedInLink { get; set; }

        [Display(
            Name = "Instagram link",
            Description = "Additional information",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual string InstagramLink { get; set; }

        [Display(
            Name = "Legal",
            Description = "Legal information",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual PageReference Legal { get; set; }
    }
}