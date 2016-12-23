using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "Event Feed", GUID = "aa0114eb-ae64-4b18-aef3-e26b27ff7f55", Description = "")]
    public class EventFeed : BlockData
    {
        [AllowedTypes(new[] { typeof(Event) })]
        [CultureSpecific]
        [Display(
           Name = "Events",
           Description = "Add new event here",
           GroupName = SystemTabNames.Content,
           Order = 10)]
        public virtual ContentArea Events { get; set; }
      
        [CultureSpecific]
        [Display(
          Name = "Header for coming events",
          GroupName = SystemTabNames.Content,
          Order = 20)]
        public virtual string HeaderComingEvents { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Header for past events",
          GroupName = SystemTabNames.Content,
          Order = 30)]
        public virtual string HeaderPastEvents { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Link text",
          Description = "The text for the button to the notification-site",
          GroupName = SystemTabNames.Content,
          Order = 40)]
        public virtual string Linktext { get; set; }

    }
}