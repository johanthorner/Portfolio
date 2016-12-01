using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "CustomersBlock", GUID = "c5b3ccbc-8544-4810-9f69-6b2f12e7ba89", Description = "")]
    public class CustomersBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Header",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Customers",
           Description = "Place customer-blocks here.",
           GroupName = SystemTabNames.Content,
           Order = 1)]
        [AllowedTypes(new[] { typeof(Customer) })]
        public virtual ContentArea CustomersArea { get; set; }

    }
}