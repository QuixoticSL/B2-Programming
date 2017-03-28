using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            char character;
            Console.WriteLine("Input character: ");
            character = (char)Console.Read();

            if (character >= 'a' && character <= 'z')
            {
                Console.WriteLine("Character {0} is lower case, uppercase should look like this: {1}", character, (char)(character - 32));
            }

            Console.ReadKey();
        }
    }
}
