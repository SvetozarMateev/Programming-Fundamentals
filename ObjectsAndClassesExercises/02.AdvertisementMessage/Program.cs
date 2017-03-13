using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> phrases = new List<string>() { "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };
            List<string> events = new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!"
                , "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"};
            List<string> author = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            Random num = new Random();

            for (int i = 0; i < n; i++)
            {
                int phrasesIndex = num.Next(0, phrases.Count);
                int eventsIndex = num.Next(0, events.Count);
                int authorIndex = num.Next(0, author.Count);
                int citiesIndex = num.Next(0, cities.Count);
                Console.WriteLine($"{phrases[phrasesIndex]} {events[eventsIndex]} {author[authorIndex]}-{cities[citiesIndex]}");

            }

        }
    }
}

