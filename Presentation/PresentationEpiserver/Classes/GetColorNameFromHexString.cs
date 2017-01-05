using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationEpiserver.Classes
{
    public class GetColorNameFromHexString
    {
        public static string getColorName(string hex)
        {
            string colorName = "";
            if (hex == "#00ff00")
            {
                colorName = "green";
            }
            return colorName;
        }
    }
}