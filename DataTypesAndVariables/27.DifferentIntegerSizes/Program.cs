using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.DifferentIntegerSizes
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            
            if (num[0] == '-')
            {
                try
                {
                    long actualNumber = long.Parse(num);
                    Console.WriteLine($"{actualNumber} can fit in:");
                    if (actualNumber >=sbyte.MinValue)
                    {
                        Console.WriteLine("* sbyte");
                    }
                    if (actualNumber >= short.MinValue)
                    {
                        Console.WriteLine("* short");
                    }
                    if (actualNumber >= int.MinValue)
                    {
                        Console.WriteLine("* int");
                    }
                  
                        Console.WriteLine("* long");
                    
                }
                catch 
                {

                    Console.WriteLine($"{num} can't fit in any type");

                }
            }
            else
            {
                try
                {
                    long actualNum = long.Parse(num);
                    Console.WriteLine($"{actualNum} can fit in:");

                    if (actualNum <=127)
                    {
                        Console.WriteLine("* sbyte");
                    }
                    if (actualNum <= 255)
                    {
                        Console.WriteLine("* byte");
                    }
                    if (actualNum <= 32767)
                    {
                        Console.WriteLine("* short");
                    }
                    if (actualNum <= ushort.MaxValue)
                    {
                        Console.WriteLine("* ushort");
                    }
                    if (actualNum <= int.MaxValue)
                    {
                        Console.WriteLine("* int");
                    }
                    if (actualNum <= uint.MaxValue)
                    {
                        Console.WriteLine("* uint");
                    }
                    if (actualNum <= long.MaxValue)
                    {
                        Console.WriteLine("* long");
                    }
                    

                }
                catch 
                {
                   
                    Console.WriteLine($"{num} can't fit in any type");
                }
            }
        }
    }
}
