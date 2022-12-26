using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH_Lab1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1.3");
            Console.WriteLine("\nТип Double:");
            double a = 100;
            double b = 0.001;
            double first = a - b;
            first = first * first * first;
            double up = first - (a * a * a);
            double down = 3 * a * (b * b) - (b * b * b) -  3 * (a * a) * b;
            double answer = up / down;
            Console.WriteLine("\n\t((a - b)^3 - a^3)" +
                "\n----------------------------------  = " + answer +
                "\n(3 * a * b^2 - b^3 - 3 * a^2 * b)");

            float af = 100f;
            float bf = 0.001f;
            float firstf = af - bf;
            firstf = firstf * firstf * firstf;
            float upf = firstf - (af * af * af);
            float downf = 3 * af * (bf * bf) - (bf * bf * bf) - 3 * (af * af) * bf;
            float answerf = upf / downf;
            Console.WriteLine("\nТип Float:");
            Console.WriteLine("\n\t((a - b)^3 - a^3)" +
                "\n----------------------------------  = " + answerf +
                "\n(3 * a * b^2 - b^3 - 3 * a^2 * b)");
            Console.ReadLine();
        }
    }
}
