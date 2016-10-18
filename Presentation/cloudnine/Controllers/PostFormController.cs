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

        [HttpGet]
        public string ManageForm()
        {
            return "Skickat";
        }

        [HttpPost]
        public string ManageForm(string sureName, string lastName, string phoneNumber, string email)
        {
           
            FormData newFormData = new FormData() { SureNameData = sureName, LastNameData = lastName, Email = email, PhoneNumber = phoneNumber };
            Session["contactMe"] = newFormData;

            FormData form = (FormData)Session["contactMe"];

            return "Skickat till: " + form.Email;

        }
    }
}