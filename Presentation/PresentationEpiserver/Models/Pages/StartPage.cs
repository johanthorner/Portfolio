using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using PresentationEpiserver.Models.Blocks;

namespace PresentationEpiserver.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "8920e26f-c50a-4c61-9e97-98182226b85f", Description = "")]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Main Content",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        public virtual ContentArea MainContent { get; set; }

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
            Description = "Place refference to startpage here",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual ContentReference StartRoot { get; set; }

        [CultureSpecific]
        [Display(
           Name = "CasePage loacation",
           Description = "",
           GroupName = SystemTabNames.Content,
           Order = 25)]
        public virtual ContentReference CaseRoot { get; set; }

        [CultureSpecific]
        [Display(
        Name = "BloggPage loacation",
        Description = "",
        GroupName = SystemTabNames.Content,
        Order = 27)]
        public virtual ContentReference BloggRoot { get; set; }

        [Display(
            Name = "Address line 1",
            Description = "Text",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual string AddressLineOne { get; set; }

        [Display(
            Name = "Address line 2",
            Description = "Text",
            GroupName = SystemTabNames.Content,
            Order = 31)]
        public virtual string AddressLineTwo { get; set; }

        [Display(
            Name = "Link to map",
            Description = "Place a link to google maps here",
            GroupName = SystemTabNames.Content,
            Order = 32)]
        public virtual string MappLink { get; set; }

        [Display(
            Name = "Link to map text",
            Description = "Enter the text for the link",
            GroupName = SystemTabNames.Content,
            Order = 33)]
        public virtual string MapLinkText { get; set; }

        [Display(
            Name = "Mail",
            Description = "Presents the post adress as text",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        public virtual string Mail { get; set; }

        [Display(
            Name = "Contact Phone",
            Description = "Presents the post adress as text",
            GroupName = SystemTabNames.Content,
            Order = 50)]
        public virtual string ContactPhone { get; set; }


        [Display(
            Name = "Contact email",
            Description = "Presents the Email as link",
            GroupName = SystemTabNames.Content,
            Order = 55)]
        public virtual string ContactEmail { get; set; }

        [Display(
            Name = "AdditionalInfo",
            Description = "Additional information",
            GroupName = SystemTabNames.Content,
            Order = 60)]
        public virtual string AdditionalInfo { get; set; }

        [Display(
          Name = "AdditionalInfoLineTwo",
          Description = "Additional information",
          GroupName = SystemTabNames.Content,
          Order = 61)]
        public virtual string AdditionalInfoLineTwo { get; set; }

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

        [Display(
          Name = "Footer Columns",
          Description = "Place a column in the footer.",
          GroupName = SystemTabNames.Content,
          Order = 100)]
        [AllowedTypes(new[] { typeof(FooterColumnBlock) })]
        public virtual ContentArea FooterColumnArea { get; set; }

        [Display(
         Name = "Social Media Area",
         Description = "Place links to social in footer.",
         GroupName = SystemTabNames.Content,
         Order = 110)]
        [AllowedTypes(new[] { typeof(SocialMediaLinkBlock) })]
        public virtual ContentArea SocialMediaArea { get; set; }
    }
}