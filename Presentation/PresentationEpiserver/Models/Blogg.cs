using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace PresentationEpiserver.Models
{
    public class Blogg
    {
        public int ID { get; set; }
        public string  Header { get; set; }
        public string Ingress { get; set; }
        public string Text { get; set; }
        public CultureInfo CultureInfo { get; set; }
    }
}