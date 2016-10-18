using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace cloudnine.Models.Blocks
{
    [ContentType(DisplayName = "EmployesBlock", GUID = "d0486957-72ed-4543-a14b-2a6934292e34", Description = "")]
    public class Employes : BlockData
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
       Name = "Employes",
       Description = "Place Employe here.",
       GroupName = SystemTabNames.Content,
       Order = 2)]
        public virtual ContentArea EmployesPhotoArea { get; set; }

    }
}