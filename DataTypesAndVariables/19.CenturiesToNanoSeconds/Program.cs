using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _19.CenturiesToNanoSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int century = int.Parse(Console.ReadLine());
            int years = century * 100;
            int days = (int)(years * 365.2422);
            ulong hours = (ulong)(days * 24);
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            BigInteger miliseconds = seconds * 1000;
            BigInteger microseconds = seconds * 1000000;
            BigInteger nanoseconds = microseconds * 1000;
            Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
