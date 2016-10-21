using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Presentation.Models;

namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
        private PostContext db = new PostContext();
        public ActionResult Index()
        {
            return View(db.Posts.ToList());
        }

        public PartialViewResult projektInfo(int id)
        {
            List<Post> activePost = db.Posts.Where(a => a.PostID == id).ToList();
            Post post = activePost[0];
           
            return PartialView(post);
        }

        public ActionResult redirectToPage(string url)
        {
            return JavaScript("window.location = '" + url + "'");
        }
        public ActionResult PostsDisplay()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}