using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SieveOfErathostenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 1)
            {
                int[] answer = new int[n + 1];
                for (int i = 2; i <= n; i++)
                {
                    if (i > 2 && i % 2 == 0)
                    {

                    }
                    else if (i > 3 && i % 3 == 0)
                    {

                    }
                    else if (i > 5 && i % 5 == 0)
                    {

                    }
                    else if (i > 7 && i % 7 == 0)
                    {

                    }
                    else if(i>11&& i % 11 == 0)
                    {

                    }
                    else if (i > 13 && i % 13 == 0)
                    {

                    }
                    else if (i > 17 && i % 17 == 0)
                    {

                    }
                    else
                    {
                        answer[i] = i;
                    }
                }

                for (int i = 0; i < answer.Length; i++)
                {
                    if (answer[i] != 0)
                        Console.Write(answer[i] + " ");

                }
                Console.WriteLine();
            }
           
           
        }
    }
}
