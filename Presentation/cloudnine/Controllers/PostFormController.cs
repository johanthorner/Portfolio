using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cloudnine.Models.Blocks;

namespace cloudnine.Controllers
{
    public class PostFormController : Controller
    {
        // GET: PostForm
      [HttpGet]
        public ActionResult ManageForm()
      {
        
          return View(new cloudnine.Models.Blocks.FormData());
      }
        [HttpPost]
        public ActionResult ManageForm(FormData formData)
        {

            return View();
        }
    }
}