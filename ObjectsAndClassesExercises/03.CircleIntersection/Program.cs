using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CircleIntersection
{
    class Circle
    {
        public double Radius { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double MyProperty
        {
            get

            {
                return this.Radius * 2;
            }
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            double[] firstCircle = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] secondCircle = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Circle first = new Circle();
            Circle second = new Circle();
            first.X = firstCircle[0];
            first.Y = firstCircle[1];
            first.Radius = firstCircle[2];
            second.X = secondCircle[0];
            second.Y = secondCircle[1];
            second.Radius = secondCircle[2];
            double distancePoints =Math.Sqrt( Math.Abs(first.X - second.X)* Math.Abs(first.X - second.X) + Math.Abs(second.Y - first.Y)* Math.Abs(second.Y - first.Y));
            if (distancePoints > first.Radius + second.Radius)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }


        }
    }
}
