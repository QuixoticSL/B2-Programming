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
            int number = 12345;

            int length = 0;

            while (number > 0)
            {
                length++;
                number /= 10;
            }
            if (length < 1) length = 1;

            Console.WriteLine(length); // 5
            Console.ReadKey();
        }
    }
}
