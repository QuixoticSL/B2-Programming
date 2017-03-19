using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double time;
            double hours;
            double minutes;
            double seconds;

            Console.WriteLine("Input time in seconds: ");
            time = int.Parse(Console.ReadLine());

            hours = 0;
            minutes = 0;
            seconds = 0;

            hours = Math.Floor(time / 3600);
            minutes = Math.Floor(time - (hours * 3600) / 60);
            seconds = Math.Floor(time - (hours * 3600) - (minutes * 60));

            Console.WriteLine("Your converted time is: {0} hours, {1} minutes and {2} seconds", hours, minutes, seconds);
            Console.ReadKey();
        }
    }
}
