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
            // Program that calculates leap years, based on what year you input
            int year;
            bool leap = false;

            Console.WriteLine("Please enter year: ");
            year = int.Parse(Console.ReadLine());

            if (year % 4 == 0)
            {
                leap = true;
            }
            if (year % 100 == 0)
            {
                leap = false;
            }
            if (year % 400 == 0)
            {
                leap = true;
            }

            if (leap)
            {
                Console.WriteLine("This {0} is a leap year!", year);
            }
            else
            {
                Console.WriteLine("Fuck you this {0} isn't a leap year!", year);
            }

            Console.ReadKey();
        }
    }
}
