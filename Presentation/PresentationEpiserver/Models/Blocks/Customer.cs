using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "Customer", GUID = "75952420-281e-4146-9808-f41d3f01ec6c", Description = "")]
    public class Customer : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name of the customer",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Name { get; set; }


        [UIHint(UIHint.Image)]
        [Display(Name = "Logotype",
        Description = "Customer logotype",
        GroupName = SystemTabNames.Content)]
        public virtual ContentReference Logotype { get; set; }
    }
}
