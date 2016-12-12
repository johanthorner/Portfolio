using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "FormArea", GUID = "3da96cab-9ffa-4d7b-bb14-c02b06aec7df", Description = "")]
    public class FormArea : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Form",
            Description = "Place form here",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual ContentArea Form { get; set; }

    }
}