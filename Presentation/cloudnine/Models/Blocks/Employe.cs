using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace cloudnine.Models.Blocks
{
    [ContentType(DisplayName = "Employe", GUID = "bf4a7751-b18d-44ad-a6b3-01d5a017bf5d", Description = "")]
    public class Employe : BlockData
    {

        [CultureSpecific]
        [Display(
              Name = "Employe name",
              Description = "The name of the employe",
              GroupName = SystemTabNames.Content,
              Order = 1)]
        public virtual string Name { get; set; }

        [CultureSpecific]
        [Display(
             Name = "Employe title",
             Description = "The name of the employe",
             GroupName = SystemTabNames.Content,
             Order = 1)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
        Name = "Employe photo",
        Description = "Place photo here.",
        GroupName = SystemTabNames.Content,
        Order = 2)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference EmployePhoto { get; set; }
    }
}