using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "ContactBlock", GUID = "216374bb-8851-49ee-860f-8b30a84b02d6", Description = "")]
    public class ContactBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Contact area",
            Description = "place contacts here.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual ContentArea ContactArea { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Contact Presentation Text",
          Description = "Place a short contact text here.",
          GroupName = SystemTabNames.Content,
          Order = 20)]
        public virtual XhtmlString ContactPresentationText { get; set; }

    }
}