using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "BloggIndexBlock", GUID = "c3468182-2299-4cdc-96ee-5ffd97173be0", Description = "")]
    public class BloggIndexBlock : BlockData
    {

        //[CultureSpecific]
        //[Display(
        //    Name = "Name",
        //    Description = "Name field's description",
        //    GroupName = SystemTabNames.Content,
        //    Order = 1)]
        //public virtual string Name { get; set; }

    }
}