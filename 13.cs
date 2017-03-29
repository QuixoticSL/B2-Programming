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
            int num1;
            int num2;

            Console.WriteLine("Enter first number: "); // this has to be less than num2
            num1 = int.Parse(Console.ReadLine()); // this has to be more than num1

            Console.WriteLine("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2) // we need a temporary variable to store the value
            {
                int temporary = num1; // temporary variable to store value
                num1 = num2; // assigning values
                num2 = temporary; // assigning values
            }

            Console.WriteLine("First number is: {0}", num1);
            Console.WriteLine("Second number is: {0}", num2);
            Console.WriteLine("Temporary variable is: {0}", temporary); // visible only in the IF statement

            Console.ReadKey();

        }
    }
}
