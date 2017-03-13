using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.CountWorkDays
{
    class Program
    {
        static void Main(string[] args)
        {           
            DateTime start = DateTime.ParseExact(Console.ReadLine(),"dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int workDays = 0;
            List<DateTime> holidays = new List<DateTime>()
            {
               DateTime.ParseExact("01-01-2016","dd-MM-yyyy",CultureInfo.InvariantCulture),
               DateTime.ParseExact("03-03-2016","dd-MM-yyyy",CultureInfo.InvariantCulture),
               DateTime.ParseExact("01-05-2016","dd-MM-yyyy",CultureInfo.InvariantCulture),
               DateTime.ParseExact("06-05-2016","dd-MM-yyyy",CultureInfo.InvariantCulture),
               DateTime.ParseExact("24-05-2016","dd-MM-yyyy",CultureInfo.InvariantCulture),
               DateTime.ParseExact("01-11-2016","dd-MM-yyyy",CultureInfo.InvariantCulture),
               DateTime.ParseExact("06-09-2016","dd-MM-yyyy",CultureInfo.InvariantCulture),
               DateTime.ParseExact("22-09-2016","dd-MM-yyyy",CultureInfo.InvariantCulture),
               DateTime.ParseExact("24-12-2016","dd-MM-yyyy",CultureInfo.InvariantCulture),
               DateTime.ParseExact("25-12-2016","dd-MM-yyyy",CultureInfo.InvariantCulture),
               DateTime.ParseExact("26-12-2016","dd-MM-yyyy",CultureInfo.InvariantCulture)
            };
            for (DateTime current = start; current <=end ; current= current.AddDays(1))
            {
                
                DateTime checker = new DateTime(2016,current.Month,current.Day);
                if (current.DayOfWeek != DayOfWeek.Saturday && current.DayOfWeek != DayOfWeek.Sunday && holidays.Contains(checker) == false)
                    workDays++;
            }
            Console.WriteLine(workDays);
            
            
        }
    }
}
