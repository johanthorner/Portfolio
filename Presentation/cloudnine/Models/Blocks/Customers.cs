using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace cloudnine.Models.Blocks
{
    [ContentType(DisplayName = "Customers", GUID = "15065592-2d5c-414e-a4c0-7506a519503e", Description = "")]
    public class Customers : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Customers",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Name { get; set; }

        [CultureSpecific]
        [Display(
        Name = "Text",
        Description = "Text for the form",
        GroupName = SystemTabNames.Content,
        Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Customers area",
          Description = "Place customer blocks here.",
          GroupName = SystemTabNames.Content,
          Order = 2)]
        public virtual ContentArea CustomersArea { get; set; }

    }
}