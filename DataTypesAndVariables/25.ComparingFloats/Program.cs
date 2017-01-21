using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double double1 = double.Parse(Console.ReadLine());
            double double2 = double.Parse(Console.ReadLine());
            // Define the tolerance for variation in their values
            double difference = 0.000001;
            // Compare the values
            // The output to the console indicates that the two values are equal
            if (Math.Abs(double1 - double2) <= difference)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
