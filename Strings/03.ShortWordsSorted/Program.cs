using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = ".,:;()[]\"'\\/!? ".ToCharArray();
            List<string> words = Console.ReadLine().ToLower().Split(separators).OrderBy(x => x).ToList();
            var shortwords = words.Where(x => x.Length < 5).Where(x => x.Length>0).Distinct().ToList();
            Console.WriteLine(string.Join(", ", shortwords));
        }
    }
}
