using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "JobbFeedBlock", GUID = "b62b3e32-1925-4625-8e78-2a87344b5be0", Description = "")]
    public class JobbFeedBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Header",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Jobbs",
           Description = "place jobb-blocks here",
           GroupName = SystemTabNames.Content,
           Order = 20)]
        public virtual ContentArea JobbArea { get; set; }

        [CultureSpecific]
        [Display(
         Name = "Link text",
         Description = "The text that will be displayed on every jobb-block.",
         GroupName = SystemTabNames.Content,
         Order = 30)]
        public virtual string LinkText { get; set; }
    }
}