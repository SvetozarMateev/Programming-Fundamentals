using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();
            int shortestLen = Math.Min(firstArray.Length, secondArray.Length);
            
            int counter = 0;
            for (int i = 0; i < shortestLen; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    counter++;
                }
                
               
            }
            int secondCounter = 0;
            firstArray=firstArray.Reverse().ToArray();
            secondArray=secondArray.Reverse().ToArray();
            for (int i = 0; i < shortestLen; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    secondCounter++;
                }
            }

            Console.WriteLine(Math.Max(counter,secondCounter));
        }
    }
}
