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
            string name = "John";
            string surname = "Smith";
            string mayor = "Information Science";

            long studentNumber = 19127572;

            Console.WriteLine("Your name is {0} {1}\nYour mayor is {2}\nand your student number is {3}", name, surname, mayor, studentNumber);
            Console.ReadKey();
        }
    }
}
