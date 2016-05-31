using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Presentation.Models
{
    public class Post
    {
        [Key]
        public int PostID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public bool IsVisible { get; set; }
        public string Link { get; set; }
        public string GithubLink { get; set; }
    }
}