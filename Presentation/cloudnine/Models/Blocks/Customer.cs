using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace cloudnine.Models.Blocks
{
    [ContentType(DisplayName = "Customer", GUID = "1144ac6c-d57c-4aa9-b9b3-e19ad2c0eef0", Description = "")]
    public class Customer : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Customer name",
            Description = "Customer name",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Name { get; set; }

        [CultureSpecific]
        [Display(
        Name = "Customers Logo Area",
        Description = "Place customer blocks here.",
        GroupName = SystemTabNames.Content,
        Order = 2)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference CustomersLogoArea { get; set; }

    }
}