using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace cloudnine.Models.Blocks
{
    [ContentType(DisplayName = "ContactMeForm", GUID = "8442d144-75ed-4778-b8af-e12d41a0d262", Description = "")]
    public class ContactMeForm : BlockData
    {
       

        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name field's description",
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
    }
}