using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Presentation.Models
{
    public class PostCollection
    {
        public int ID { get; set; }
        public List<Post> Posts { get; set; }
    }
}