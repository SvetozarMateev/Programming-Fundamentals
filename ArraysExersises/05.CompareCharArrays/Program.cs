using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
           
                string[] first = Console.ReadLine().Split(' ').ToArray();
                string[] second = Console.ReadLine().Split(' ').ToArray();
                int length = Math.Min(first.Length, second.Length);
                bool equal = true;
                for (int i = 0; i < length; i++)
                {

                    if (first[i].CompareTo(second[i]) != 0)
                    {
                        equal = false;
                        if (first[i].CompareTo(second[i]) > 0)
                        {
                            Console.WriteLine(string.Join("", second));
                            Console.WriteLine(string.Join("", first));
                        }
                        else
                        {
                            Console.WriteLine(string.Join("", first));
                            Console.WriteLine(string.Join("", second));

                        }
                        break;
                    }
                }
                if (equal)
                {
                    if (first.Length > second.Length)
                    {
                        Console.WriteLine(string.Join("", second));
                        Console.WriteLine(string.Join("", first));
                    }
                    else
                    {

                        Console.WriteLine(string.Join("", first));
                        Console.WriteLine(string.Join("", second));
                    }
                }
            

        }
    }
}
