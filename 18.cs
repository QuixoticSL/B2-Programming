using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 25, b = 9;
            int x = ((a % b) == 7) ? a : b; // if the condition inside the brackets is true, console will write out a(25)
                                            // if the condition inside the brackets is false, console will write out b(9)
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
