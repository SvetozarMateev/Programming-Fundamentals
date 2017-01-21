using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long amountOfPictures = long.Parse(Console.ReadLine());
            long filteringTime = long.Parse(Console.ReadLine());
            long percentageGoodPhotos = long.Parse(Console.ReadLine());
            decimal uploadTime = decimal.Parse(Console.ReadLine());

            decimal timeInSeconds = amountOfPictures* filteringTime;
            decimal usefulPics =(decimal)(Math.Ceiling( amountOfPictures * percentageGoodPhotos / 100.0));
            timeInSeconds +=usefulPics * uploadTime;
            int secondsDay = 24 * 3600;
            int secondsHours = 3600;
            int secondsMinute = 60;

            long days = (long)(timeInSeconds / secondsDay);
            timeInSeconds -= days * secondsDay;
            long hours = (long)(timeInSeconds / secondsHours);
            timeInSeconds -= hours * secondsHours;
            long minute = (long)(timeInSeconds / secondsMinute);
            timeInSeconds -= minute * secondsMinute;
           // 0:00:25:00
            Console.Write($"{days}:");
            Console.Write($"{hours}:".PadLeft(3,'0'));
            Console.Write($"{minute}:".PadLeft(3, '0'));
            Console.Write($"{timeInSeconds}".PadLeft(2, '0'));
            Console.WriteLine();

        }
    }
}
