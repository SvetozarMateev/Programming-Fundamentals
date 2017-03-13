using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05.ConvertFromBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToList();
            BigInteger system = numbers[0];
            BigInteger num = numbers[1];
            if (num != 0&&system!=0)
            {
                StringBuilder answer = new StringBuilder();
                while (num>0)
                {

                    answer.Append(num % system);
                    num = num / system;
                   
                }
                string result = answer.ToString();
                char[] arr = result.ToCharArray();
                arr = arr.Reverse().ToArray();
                Console.WriteLine(string.Join("", arr));
                
            }
           
        }
    }
}
