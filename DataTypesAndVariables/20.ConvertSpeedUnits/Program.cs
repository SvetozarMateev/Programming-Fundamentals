using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal distanceInMeters = decimal.Parse(Console.ReadLine());
            decimal hours = decimal.Parse(Console.ReadLine());
            decimal minutes = decimal.Parse(Console.ReadLine());
            decimal seconds = decimal.Parse(Console.ReadLine());
            decimal distanceInKm = distanceInMeters / 1000m;
            decimal distanceInMiles = distanceInKm / 1.609m;
            decimal timeHours = hours + minutes / 60 + seconds / 3600;
            decimal timeSeconds = hours * 3600 + minutes * 60 + seconds;
            decimal speedKMPH =distanceInKm/timeHours;
            decimal speedMetersPerSecond =distanceInMeters/timeSeconds;
            decimal speedMPH =distanceInMiles/timeHours;
            Console.WriteLine("{0}",Math.Round(speedMetersPerSecond,6, MidpointRounding.AwayFromZero));
            Console.WriteLine("{0}",Math.Round(speedKMPH,5,MidpointRounding.AwayFromZero));
            Console.WriteLine("{0}",Math.Round(speedMPH,5,MidpointRounding.AwayFromZero));

        }
    }
}
