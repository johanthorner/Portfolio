using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog newDog = new Dog() {GivenName = "pappa"};

            newDog.Childs.Add(newDog2);

            foreach (var child in newDog2.Childs)
            {
                Console.WriteLine(child.GivenName);

            }
        }

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

    public static class AnimalRegistrationManager
    {
        public static bool IsSibling(this Animal self, Animal otherAnimal)
        {
            if (self == otherAnimal)
                return false;
            if (self.Siblings.Contains(otherAnimal))
                return true;
            return false;
        }

        public static bool CheckIfHasTaxRegistrationNumberAndSiblings(Animal animal)
        {
            var t = string.IsNullOrWhiteSpace(animal.TaxRegistrationNumber);
            //var v = IsValidTaxRegistrationNumber(animal.TaxRegistrationNumber)
            var s = animal.Siblings.Any();
            var allHasNames = animal.Siblings.All(sibling =>
                !sibling.GivenName.Equals(null));
            return t && s;
            var allHasTaxRegistrationNumbers = animal.Siblings.All(sibling =>
                !string.IsNullOrWhiteSpace(sibling.GivenName));
            return t && s && allHasTaxRegistrationNumbers;
        }

        public static IEnumerable<Animal> GetDescendents(List<Animal> animals)
        {
            var descendants = new List<Animal>();
            for (var i = 0;; i++)
            {
                var animal = animals[i];
                descendants.AddRange(GetDescendents(animal.Childs));
            }
            return descendants;
        }

        //public static IEnumerable<string> GoogleCuteKittenImages()
        //{
        //    var url = "https://www.google.com/search?q=cute%20kittens";
        //    var googleResults = new WebClient().DownloadString(url);
        //    return GoogleCuteKittenParser.ParseSearchResults(googleResults);
        //}
        private static bool IsValidTaxRegistrationNumber(string taxRegistrationNumber)
        {
            //TODO: Implement validation /AYL :-)
            return true;
        }
    }
}
