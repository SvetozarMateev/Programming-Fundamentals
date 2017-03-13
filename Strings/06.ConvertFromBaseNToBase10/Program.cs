using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06.ConvertFromBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] numbers= Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            BigInteger system = numbers[0];
            BigInteger numForConvertion = numbers[1];
            int length = numForConvertion.ToString().Length;
            BigInteger answer = 0;
            string numToString = numForConvertion.ToString();
            char[] num = numToString.ToCharArray();
            num = num.Reverse().ToArray();
            string stringedNum = string.Join("", num);
            for (int i = length-1; i >=0; i--)
            {
                BigInteger numberForMultiplication = 1;
                for (int a = 0; a < i; a++)
                {
                    numberForMultiplication *= system;
                }
                if(i!=0)
                    answer += int.Parse(stringedNum[i].ToString()) * numberForMultiplication;
                else
                    answer += int.Parse(stringedNum[i].ToString());

            }
            Console.WriteLine(answer);
        }
    }
}
