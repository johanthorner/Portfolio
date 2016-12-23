using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "Event", GUID = "732af3b1-3ffc-4b9f-9d77-cd882d48eaf3", Description = "")]
    public class Event : BlockData
    {
   
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Text",
          Description = "A presentation of the event.",
          GroupName = SystemTabNames.Content,
          Order = 20)]
        public virtual XhtmlString Text { get; set; }

        [CultureSpecific]
        [Display(
         Name = "Speaker",
         GroupName = SystemTabNames.Content,
         Order = 30)]
        public virtual string Speaker { get; set; }

        [CultureSpecific]
        [Display(
         Name = "Date and time",
         GroupName = SystemTabNames.Content,
         Order = 40)]
        public virtual DateTime DateAndTime { get; set; }

        [CultureSpecific]
        [Display(
        Name = "Adress",
        GroupName = SystemTabNames.Content,
        Order = 50)]
        public virtual string Adress { get; set; }

        [CultureSpecific]
        [Display(
        Name = "AditionalInfo",
        Description = "A line of text under the adress-line",
        GroupName = SystemTabNames.Content,
        Order = 60)]
        public virtual string AddtionalInfo { get; set; }

        [UIHint(UIHint.Image)]
        [Display(Name = "Image",
              Order = 70,
              Description = "Place the image-file here",
              GroupName = SystemTabNames.Content)]
        public virtual ContentReference Image { get; set; }

        [CultureSpecific]
        [Display(
        Name = "Link",
        Description = "Link to the page of the event",
        GroupName = SystemTabNames.Content,
        Order = 80)]
        public virtual string Link { get; set; }

    }
}