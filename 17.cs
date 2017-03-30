using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Algorythm that calculates what day it is when you enter a year, month and day

            int year, month, day;
            string nameDay = "";

            Console.WriteLine("Please enter year: ");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter month: ");
            month = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter day: ");
            day = int.Parse(Console.ReadLine());

            if (month < 3)
            {
                month = month + 12;
                year = year - 1;
            }

            int a = 2 * month + 6 * (month + 1) / 10;
            int b = year + year / 4 - year / 100 + year / 400;
            int f1 = day + a + b + 1;
            int f = f1 % 7;

            switch (f)
            {
                case 0:
                    nameDay = "Sunday";
                    break;
                case 1:
                    nameDay = "Monday";
                    break;
                case 2:
                    nameDay = "Tuesday";
                    break;
                case 3:
                    nameDay = "Wednesday";
                    break;
                case 4:
                    nameDay = "Thursday";
                    break;
                case 5:
                    nameDay = "Friday";
                    break;
                case 6:
                    nameDay = "Saturday";
                    break;
            };

            Console.WriteLine("The day is: {0}", nameDay);
            Console.ReadKey();
        }
    }
}
