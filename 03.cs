using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaje
{
    class Program
    {
        static void Main(string[] args)
        {
            int Spr1, Spr2; // Assign the variables

            Console.Write("Enter first integer: "); // Give the program the first integer
            Spr1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: "); // Give the program a second integer
            Spr2 = int.Parse(Console.ReadLine()); // int.Parse converts the parameter we gave it into an integer

            Console.WriteLine("{0} + {1} = {2}", Spr1, Spr2, Spr1 + Spr2);
            // The numbers in curly brackets are parameters.

            Console.WriteLine("{0} - {1} = {2}", Spr1, Spr2, Spr1 - Spr2);
            // The numbers in curly brackets are parameters.

            Console.WriteLine("{0} * {1} = {2}", Spr1, Spr2, Spr1 * Spr2);
            // The numbers in curly brackets are parameters.

            Console.WriteLine("{0} / {1} = {2}", Spr1, Spr2, (double)Spr1 / Spr2); // Shows the decimal points
            // The numbers in curly brackets are parameters.

            Console.WriteLine("{0} % {1} = {2}", Spr1, Spr2, Spr1 % Spr2);
            // The numbers in curly brackets are parameters.

            Console.ReadKey(); //Always include this at the end of your code.
        }
    }
}
