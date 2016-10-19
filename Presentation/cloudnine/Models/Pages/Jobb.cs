using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace cloudnine.Models.Pages
{
    [ContentType(DisplayName = "Jobb", GUID = "cdcb8272-08a1-4e6e-b605-db6723dff081", Description = "")]
    public class Jobb : PageData
    {

        [CultureSpecific]
        [Display(
          Name = "Headline for jobb",
          Description = "",
          GroupName = SystemTabNames.Content,
          Order = 1)]
        public virtual XhtmlString HeadLine { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Text for jobb",
           Description = "",
           GroupName = SystemTabNames.Content,
           Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

      
    }
}