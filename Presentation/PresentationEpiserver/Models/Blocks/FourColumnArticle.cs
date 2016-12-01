using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "FourColumnArticle", GUID = "047daf62-41c6-47e6-80e3-b5d01cc6f4e7", Description = "")]
    public class FourColumnArticle : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Header",
            Description = "A header to be presented above the columns",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Header { get; set; }

        [UIHint(UIHint.Image)]
        [Display(
            Name = "Image 1",
            Description = "Center-collumn image",
            Order = 20,
            GroupName = SystemTabNames.Content)]
        public virtual ContentReference ImageOne { get; set; }
        [CultureSpecific]
        [Display(
            Name = "Header 1",
            Description = "A header to be presented above the columns",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual string HeaderOne { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Text 1",
          Description = "Presented ass a column.",
          GroupName = SystemTabNames.Content,
          Order = 40)]
        public virtual XhtmlString TextOne { get; set; }

        [UIHint(UIHint.Image)]
        [Display(Name = "Image 2",
           Description = "Center-collumn image",
           Order = 50,
           GroupName = SystemTabNames.Content)]
        public virtual ContentReference ImageTwo { get; set; }
        [CultureSpecific]
        [Display(
           Name = "Header 2",
           Description = "A header to be presented above the columns",
           GroupName = SystemTabNames.Content,
           Order = 60)]
        public virtual string HeaderTwo { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Text 2",
          Description = "Presented ass a column.",
          GroupName = SystemTabNames.Content,
          Order = 70)]
        public virtual XhtmlString TextTwo { get; set; }

        [UIHint(UIHint.Image)]
        [Display(Name = "Image 3",
           Description = "Center-collumn image",
           Order = 80,
           GroupName = SystemTabNames.Content)]
        public virtual ContentReference ImageThree { get; set; }
        [CultureSpecific]
        [Display(
           Name = "Header 3",
           Description = "A header to be presented above the columns",
           GroupName = SystemTabNames.Content,
           Order = 90)]
        public virtual string HeaderThree { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Text 3",
          Description = "Presented ass a column.",
          GroupName = SystemTabNames.Content,
          Order = 100)]
        public virtual XhtmlString TextThree { get; set; }

        [UIHint(UIHint.Image)]
        [Display(Name = "Image 4",
           Description = "Center-collumn image",
           Order = 110,
           GroupName = SystemTabNames.Content)]
        public virtual ContentReference ImageFour { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Header 4",
           Description = "A header to be presented above the columns",
           GroupName = SystemTabNames.Content,
           Order = 120)]
        public virtual string HeaderFour { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Text 4",
          Description = "Presented ass a column.",
          GroupName = SystemTabNames.Content,
          Order = 130)]
        public virtual XhtmlString TextFour { get; set; }


    }
}