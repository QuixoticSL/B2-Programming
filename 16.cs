using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculate your grade based on how many points you got out of 100
            double num;
            int grade = 0;

            Console.WriteLine("Type in a number from 0 to 100:");
            num = double.Parse(Console.ReadLine());

            if (num > 100)
            {
                Console.WriteLine("Number must be between 0 and 100!!");
            }
            else
            {
                if (num >= 0 && num < 50)
                {
                    grade = 1;
                }
                else if (num >= 50 && num < 63)
                {
                    grade = 2;
                }
                else if (num >= 63 && num < 76)
                {
                    grade = 3;
                }
                else if (num >= 76 && num < 88)
                {
                    grade = 4;
                }
                else
                {
                    grade = 5;
                }

                Console.WriteLine("Your grade is {0}", grade);
            };

            Console.ReadKey();
        }
    }
}
