using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int num = Convert.ToInt32(number, 16);
            Console.WriteLine(num);
        }
    }
}
