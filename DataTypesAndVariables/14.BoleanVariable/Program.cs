using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BoleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry = Console.ReadLine();
            bool result = Convert.ToBoolean(entry);
            if(result)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
