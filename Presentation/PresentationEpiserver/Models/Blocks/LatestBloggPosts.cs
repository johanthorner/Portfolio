using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "Latest Blogg Posts", GUID = "7f271966-ab24-400e-9140-5892541dfdb2", Description = "")]
    public class LatestBloggPosts : BlockData
    {
        [CultureSpecific]
        [Display(
          Name = "Header",
          Description = "Blogg header",
          GroupName = SystemTabNames.Content,
          Order = 10)]
        public virtual string Header { get; set; }
    }
}