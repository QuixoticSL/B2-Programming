using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaje
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort x;

            Console.Write("Enter integer: ");
            x = ushort.Parse(Console.ReadLine());

            ++x; // Increments x but doesn't change the value.

            Console.WriteLine(x);

            x++; // Will increment the value, but then return its old value.
                 // The same goes for x-- only in reverse

            Console.WriteLine(x);
            Console.WriteLine(++x);
            Console.WriteLine(x);
            Console.WriteLine(x++);
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
