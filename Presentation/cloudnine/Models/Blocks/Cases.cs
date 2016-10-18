using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace cloudnine.Models.Blocks
{
    [ContentType(DisplayName = "Cases", GUID = "71a3d38f-7f75-4504-b82b-3a1540c08ea6", Description = "")]
    public class Cases : BlockData
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
       Description = "Text for cases",
       GroupName = SystemTabNames.Content,
       Order = 2)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
         Name = "cases area",
         Description = "Place case blocks here.",
         GroupName = SystemTabNames.Content,
         Order = 3)]
        public virtual ContentArea CasesArea { get; set; }
    }
}