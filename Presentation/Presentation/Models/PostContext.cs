using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Presentation.Models
{
    public class PostContext : DbContext
    {
        public PostContext() : base("PostDatabase")
        {
            Database.SetInitializer<PostContext>(new PostContextInitializer());
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCollection> PostCollections { get; set; }
    }

    public class PostContextInitializer : DropCreateDatabaseAlways<PostContext>
    {
        protected override void Seed(PostContext context)
        {
            List<Post> posts = new List<Post>()
            {
                new Post() {PostID = 1, Text = "Ett projekt med html och css",Link = "http://dev15johtho.se/", GithubLink = "https://github.com/johanthorner", Title = "HTML5", IsVisible = true},
                new Post() {PostID = 2, Text = "Lite text JAvaScript projektet",Link = "", Title = "JavaScript", IsVisible = true},
                new Post() {PostID = 3, Text = "Lite text MVC projektet",Link = "", Title = "MVC", IsVisible = true},
                new Post() {PostID = 4, Text = "Lite text SharePoint projektet",Link = "", Title = "SharePoint", IsVisible = false},
                new Post() {PostID = 5, Text = "Lite text om projektet",Link = "", Title = "New Post", IsVisible = false}
            };
            foreach (var post in posts)
            {
                context.Posts.Add(post);
            }
            context.SaveChanges();

           
        }
    }
}