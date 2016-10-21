using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat newCat= new Cat();
            Animal newAnimal = new Johan();
            Console.WriteLine(newAnimal.GetScientificName());
            //IceCream();
            // FooMethod();
        }

        public class Johan : Animal
        {
            
        }
        public class Cat : Animal
        {
        }
        public class Dog : Animal
        {
        }
        public abstract class Animal
        {
            protected Animal()
            {
                Childs = new List<Animal>();
            }
            public string GivenName { get; set; }
            public string TaxRegistrationNumber { get; set; }
            public List<Animal> Siblings { get; set; }
            public List<Animal> Childs { get; set; }
            public string GetScientificName()
            {
                if (this is Cat)
                    return "Felis catus";
                if (this is Dog)
                    return "Canis lupus familiaris";
                throw new Exception("Unknown animal");
            }
        }
        private static void IceCream()
        {
            IceCreamTruck iceCreamTruck = new IceCreamTruck();
            var json = new JavaScriptSerializer().Serialize(iceCreamTruck);
            Console.WriteLine(json);
            Console.ReadLine();
        }


        private static void FooMethod()
        {
            var arr = new foo[2]
            {
                new foo() {id = 1},
                new foo() {id = 2}
            };
            var numbers = from num in arr select num.id;

            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        class foo
        {
            public int id { get; set; }
            public string str { get; set; }
        }

        abstract class Däggdjur
        {
            public abstract void Tala();
        }

        class Hund : Däggdjur
        {
            public override void Tala()
            {
                
            }
        }
        public abstract class Car
        {
            public int numberOfDoors { get; set; }
            public string model { get; set; }
        }
        public class IceCreamTruck : Car
        {

            public string iceCreamFlava { get; set; }

        }
}
}
