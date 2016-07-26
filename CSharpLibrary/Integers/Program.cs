using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 54;  //Integer type (32 bit)
            Console.WriteLine($"32 bit integer, {i}");

            short sh = 32767;
            Console.WriteLine($"16 bit integer, {sh}");

            long Lo = 54678656789;
            Console.WriteLine($"64 bit integer, {Lo}");

            //Adding integers
            int a = 5;
            int b = 3;
            int c = a + b;
            Console.WriteLine($"Adding a + b = {c} where a = 5 and b = 3");

            //Subtracting integers
            int a2 = 5;
            int b2 = 3;
            int c2 = a2 - b2;
            Console.WriteLine($"Subtracting a - b = {c2} where a = 5 and b = 3");

            //Multiplying integers
            int a3 = 5;
            int b3 = 3;
            int c3 = a3 * b3;
            Console.WriteLine($"Multiplying a * b = {c3} where a = 5 and b = 3");

            int a4 = 6;
            int b4 = 3;
            int c4 = a4 / b4;
            Console.WriteLine($"Dividing a / b = {c4} where a = 6 and b = 3");


            double a5 = 2;
            double b5 = 3;
            double c5 = Math.Pow(a5, b5);
            Console.WriteLine($"Calculating an exponent expression where 2 is raised to the 3rd power, {c5}");


            //Console.WriteLine("Hello World");
            Console.ReadLine();
        }
    }
}
