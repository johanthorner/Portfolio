using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace PresentationEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "FullColumnArticle", GUID = "1eb5d1e7-ea11-4e34-8095-d3bbf30a05a3", Description = "")]
    public class FullColumnArticleBlock : BlockData
    {
        [UIHint(UIHint.Image)]
        [Display(
            Name = "Image",
            Description = "Center-collumn image",
            Order = 10,
            GroupName = SystemTabNames.Content)]
        
        public virtual ContentReference Image { get; set; }
        [CultureSpecific]
        [Display(
            Name = "Header",
            Description = "Header for the article",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Text",
           Description = "Presented ass a column.",
           GroupName = SystemTabNames.Content,
           Order = 30)]
        public virtual XhtmlString Text { get; set; }
    }
}