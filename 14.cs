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
            double amount;
            double provision;

            Console.WriteLine("Type the value: ");
            amount = double.Parse(Console.ReadLine());

            provision = amount * 0.001;

            if (provision > 2.5) // the provision can't be more than 2.5
            {
                provision = 2.5; // if the provision is more than 2.5, we treat it as 2.5
            }

            Console.WriteLine("Amount is: {0}", amount);
            Console.WriteLine("Provision is: {0}", provision);
            Console.ReadKey();
        }
    }
}
