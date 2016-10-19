using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace cloudnine.Models.Blocks
{
    [ContentType(DisplayName = "CasesPresentation", GUID = "7091cf1c-e07d-4d98-a721-f6255cada8fc", Description = "")]
    public class CasesPresentation : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Case Presentation",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string CasePresentation { get; set; }

    }
}