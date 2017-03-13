using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string first = input[0];
            string second = input[1];
            BigInteger answer = 0;
            if (first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    BigInteger firstNum = first[i];
                    BigInteger secondNum = second[i];
                    answer += firstNum * secondNum;
                }
            }
            else
            {
                if (first.Length < second.Length)
                {
                    for (int i = 0; i < first.Length; i++)
                    {
                        BigInteger firstNum = first[i];
                        BigInteger secondNum = second[i];
                        answer += firstNum * secondNum;
                    }
                    for (int i = first.Length; i < second.Length; i++)
                    {
                        ulong secondNum = second[i];

                        answer += secondNum;
                    }
                }
                else
                {
                    for (int i = 0; i < second.Length; i++)
                    {
                        BigInteger firstNum = first[i];
                        BigInteger secondNum = second[i];
                        answer += firstNum * secondNum;
                    }
                    for (int i = second.Length; i < first.Length; i++)
                    {
                        BigInteger firstNum = first[i];

                        answer += firstNum;
                    }
                }
            }
            Console.WriteLine(answer);

        }
    }
}
