using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pick a random number between 1 and 6
            int num1, num2, num3;

            Random r = new Random(); // picks from the random selection of numbers

            num1 = r.Next(1, 7); // type in the range, but 6 isn't included so we type 7
            num2 = r.Next(1, 7);
            num3 = r.Next(1, 7);

            if (num1 == num2 && num3 == num1)
            {
                Console.WriteLine("Jackpot!!!");
            }

            Console.WriteLine("{0}, {1}, {2}", num1, num2, num3);
            Console.ReadKey();

        }
    }
}
