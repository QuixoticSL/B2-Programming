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
            double velocity;
            double time;
            double gravity = 9.81;

            Console.WriteLine("Write the desired time in seconds: ");
            time = int.Parse(Console.ReadLine());

            velocity = gravity * time;

            Console.WriteLine("After {0} seconds the falling speed will be {1} m/s", time, velocity);
            Console.ReadKey();
        }
    }
}
