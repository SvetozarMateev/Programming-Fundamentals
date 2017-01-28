using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] firstElements = new int[input.Length / 4];
            int[] midElements = new int[input.Length / 2];
            int[] LastElements = new int[input.Length / 4];
            int[] firstAndLastElements = new int[input.Length / 2];
            for (int i = 0; i < input.Length/4; i++)
            {
                
                    firstElements[i] = input[i];
                
            }
            for (int i = input.Length/4 ; i < input.Length*3/4; i++)
            {

                   midElements[i-input.Length/4] = input[i];
                
            }
            for (int i = input.Length*3/4; i < input.Length; i++)
            {
                LastElements[i-input.Length*3/4] = input[i];
            }
                
            
            firstElements = firstElements.Reverse().ToArray();
            LastElements = LastElements.Reverse().ToArray();
            for (int i = 0; i < midElements.Length / 2; i++)
            {
                firstAndLastElements[i] = firstElements[i];
            }
            for (int i = midElements.Length/2; i < midElements.Length; i++)
            {
                firstAndLastElements[i] = LastElements[i-midElements.Length/2];
            }
            for (int i = 0; i < midElements.Length; i++)
            {
                firstAndLastElements[i] += midElements[i];
            }
            Console.WriteLine(string.Join(" ",firstAndLastElements));



        }
    }
}
