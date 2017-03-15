using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            bool boolSpr = true;
            char charSpr = (char)382; // type ASCII characters for letters
            sbyte sbyteSpr = -100;
            byte byteSpr = 10;
            short shortSpr = 1000;
            ushort ushorSpr = 1200;
            int intSpr = -10000000;
            uint uintSpr = 10000000;
            long longSpr = 100000000000000;
            ulong ulongSpr = 100000000000000;
            float floatSpr = 1.23F;
            double doubleSpr = 1.234;
            decimal decimalSpr = 1.234m;
            string stringSpr = "Hello";

            Console.WriteLine("boolSpr =" + boolSpr + " This equals true!);
            Console.WriteLine("charSpr = {0} we can continue here", charSpr);
            Console.WriteLine(sbyteSpr);
            Console.WriteLine(byteSpr);
            Console.WriteLine(shortSpr);
            Console.WriteLine(ushorSpr);
            Console.WriteLine(intSpr);
            Console.WriteLine(uintSpr);
            Console.WriteLine(longSpr);
            Console.WriteLine(ulongSpr);
            Console.WriteLine(floatSpr);
            Console.WriteLine(doubleSpr);
            Console.WriteLine(decimalSpr);
            Console.WriteLine(stringSpr);

            // Math operations all apply when using Console.WriteLine();
            Console.ReadKey();
        }
    }
}
