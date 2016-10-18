using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace cloudnine.Models.Media
{
    [ContentType(DisplayName = "DefaultMedia1", GUID = "b6412510-777f-4c47-bcd7-e5fb5cc2911e", Description = "")]
    [MediaDescriptor(ExtensionString = "jpg,png")]
    public class ImageMedia : ImageData
    {

        [CultureSpecific]
        [Editable(true)]
        [Display(
            Name = "Description",
            Description = "Description field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Description { get; set; }

    }
}