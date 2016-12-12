using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "Contact", GUID = "fcaaa480-95ce-4eaf-aa01-a1ae5b1a2a85", Description = "")]
    public class Contact : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name of the person",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Name { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Email",
           Description = "",
           GroupName = SystemTabNames.Content,
           Order = 20)]
        public virtual string Email { get; set; }

        [UIHint(UIHint.Image)]
        [Display(
        Name = "Photo",
        Description = "Contact Photo",
        GroupName = SystemTabNames.Content,
        Order = 30)]
        public virtual ContentReference Photo { get; set; }

        [CultureSpecific]
        [Display(
         Name = "Title",
         Description = "The title of the person",
         GroupName = SystemTabNames.Content,
         Order = 40)]
        public virtual string Title { get; set; }


    }
}