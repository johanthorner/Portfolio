using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cloudnine.Models.Blocks
{
    public class FormData
    {
       
        public string  SureNameData { get; set; }
        public string LastNameData{ get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        //TODO: En Sån där kontroll..
        //TODO: Validering av input
    }
}