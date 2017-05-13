using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration of variables
            int inputedNumbers;
            int sumPos = 0;
            int sumNeg = 0;
            int i = 0;

            // Getting numbers from user
            Console.WriteLine("Sum of positive and negative numbers with do-while loop.");

            do
            {
                Console.WriteLine("Please enter 20 numbers: ");
                inputedNumbers = Convert.ToInt32(Console.ReadLine());

                if (inputedNumbers > 0) // If inputed number is positive
                {
                    sumPos += inputedNumbers; // Give it to sumPos
                } else
                {
                    sumNeg += inputedNumbers; // Else give it to sumNeg
                }

            } while (i < 20);

            // Writing out results
            Console.WriteLine("Sum of positive numbers is: {0}", sumPos);
            Console.WriteLine("Sum of negative numbers is: {0}", sumNeg);
            Console.ReadKey();
        }
    }
}
