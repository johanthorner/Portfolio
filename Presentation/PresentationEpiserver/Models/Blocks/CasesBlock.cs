using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "CasesBlock", GUID = "860670f7-15b7-4f84-8de0-43a1c164d5f2", Description = "")]
    public class CasesBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Displays the subisites to this page ass images on this page.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Name { get; set; }

    }
}