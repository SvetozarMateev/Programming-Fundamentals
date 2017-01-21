using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if(input=="1"||input=="2"||input=="3"||input=="4"|| input=="5"||input=="6"||input=="7"||input=="8"||input=="9"||input=="0")
                Console.WriteLine("digit");
            else if(input=="a"||input=="e"||input=="o"||input=="i"||input=="u"||input=="y")
                Console.WriteLine("vowel");
            else
                Console.WriteLine("other");
        }
    }
}
