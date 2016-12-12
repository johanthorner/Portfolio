using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;

namespace PresentationEpiserver.Classes
{
    public class ContactBlockViewModel
    {
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string  AdditionalInfo{ get; set; }
        public XhtmlString ContactPresentationText { get; set; }
        public ContentReference ContactArea { get; set; }
    }
}