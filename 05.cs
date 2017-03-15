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
            double r;
            double pi = 3.141;

            Console.Write("Enter integer(r): "); // we need the user to input a number for r to be used in the calculation
            r = double.Parse(Console.ReadLine());

            double cir = 2 * r * pi; // standard equations for calculating circle stuff :P
            double area = r * r * pi;

            Console.WriteLine("Circumference of a circle with a radius of {0} is {1}", r, cir); // r is the 0 parameter and obseg is the 1 parameter
            Console.WriteLine("Area of ​​a circle with a radius of {0} is {1}", r, area); // r is the 0 parameter and povrsina is the 1 parameter

            Console.ReadKey();
        }
    }
}
