using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majoWoff
{
    class Program
    {
        static void Main(string[] args)
        {
            Katt missan = new Katt();
           
            Console.WriteLine(missan.tala());
        }

    }
    public class Katt : Djur { }
    public class Hund : Djur { }

    public class Djur
    {
        public string tala()
        {
            if (this is Katt)
            {
                return "Majo";
            }
            if (this is Hund)
            {
                return "Woff";
            }
            else
            {
                return "...";
            }
        }
    }
}
