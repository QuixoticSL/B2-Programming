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

            string name = "John";
            string surname = "Smith";
            string streetName = "Downing";
            string place = "England";
            int zipCode = 1200;
            int streetNum = 17;

            Console.WriteLine("{0}, {1}", name, surname);
            Console.WriteLine("{0}, {1}", streetName, place);
            Console.WriteLine("{0}, {1}", streetNum, zipCode);

            Console.ReadKey();

        }
    }
}
