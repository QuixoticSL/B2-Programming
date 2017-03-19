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
            float height;
            float weight;
            float bmi;

            Console.WriteLine("Input desired height in meters: ");
            height = float.Parse(Console.ReadLine());

            Console.WriteLine("Input desired weight in kg: ");
            weight = float.Parse(Console.ReadLine());

            bmi = weight / (height * height);

            Console.WriteLine("Your BMI is: {0}, at height {1} and weight {2}", bmi, height, weight);
            Console.ReadKey();
        }
    }
}
