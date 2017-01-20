using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace PresentationEpiserver.Models.Pages
{
    [ContentType(DisplayName = "BloggFeedPage", GUID = "2ea13498-7e8c-465c-9f9c-08155763fe6a", Description = "")]
    public class BloggFeedPage : BasePage
    {

        [CultureSpecific]
        [Display(
            Name = "Blogg feed",
            Description = "Lists all the bloggpages placed below.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual XhtmlString BloggFeed { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Blogg Intro Text",
            Description = "A short description about the content.",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString BloggIntroText { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Button Text",
            Description = "A short description about the content.",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual string ButtonText { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Number of bloggpost per page",
           Description = "The number of bloggs.",
           GroupName = SystemTabNames.Content,
           Order = 30)]
        public virtual int NumberOfBloggsPerPage { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Search-box placeholder",
          Description = "A text that will be displayed inside the searchbox",
          GroupName = SystemTabNames.Content,
          Order = 40)]
        public virtual string SearchBoxPlaceHolder { get; set; }

        [CultureSpecific]
        [Display(
         Name = "Search result text",
         Description = "Search resulted in.",
         GroupName = SystemTabNames.Content,
         Order = 50)]
        public virtual string SearchResultText { get; set; }

    }
}