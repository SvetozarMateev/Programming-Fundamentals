using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.IntToHexToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string hexNum = num.ToString("X");
            string binary = Convert.ToString(num,2);
            Console.WriteLine(hexNum);
            Console.WriteLine(binary);
        }
    }
}
