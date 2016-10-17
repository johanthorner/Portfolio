using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace cloudnine.Models.Blocks
{
    [ContentType(DisplayName = "Case", GUID = "593f31dd-cbbd-47b1-a2c5-2e2404e3c49e", Description = "")]
    public class Case : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name of Case",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Name { get; set; }

       
        [CultureSpecific]
        [Display(
          Name = "Case Image-area",
          Description = "Place Case- image here.",
          GroupName = SystemTabNames.Content,
          Order = 2)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference CaseImageArea { get; set; }


        [CultureSpecific]
        [Display(
         Name = "BootstrapColumns",
         Description = "",
         GroupName = SystemTabNames.Content,
         Order = 3)]
        public virtual int BootstrapColumns { get; set; }

    }
}