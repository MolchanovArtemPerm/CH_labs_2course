using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH_Lab1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1.1");
            string first1, twice1;
            int first, twice;
            bool isBuff = false;
            do
            {
                Console.Write("\nВведите число для n: ");
                first1 = Console.ReadLine();
                if (int.TryParse(first1, out first))
                {
                    isBuff = true;
                }
                else
                {
                    Console.WriteLine("\nОшибка, нужно ввести целое число");
                }
            } while (!isBuff);
            isBuff = false;
            do
            {
                Console.Write("\nВведите число для m: ");
                twice1 = Console.ReadLine();
                if (int.TryParse(twice1, out twice))
                {
                    isBuff = true;
                }
                else
                {
                    Console.WriteLine("\nОшибка, нужно ввести целое число");
                }
            } while (!isBuff);
            // 1
            Console.WriteLine("\nn = " + first + ", m = " + twice + " n++ * m = " + first * twice);
            first++;
            // 2
            isBuff = first < twice;
            Console.WriteLine("\nn = " + first + ", m = " + twice + " n++ < m = " + isBuff);
            first++;
            // 3
            twice--;
            isBuff = twice > first;
            Console.WriteLine("\nn = " + first + ", m = " + twice + " --m > n = " + isBuff);
            //4
            double x;
            isBuff = false;
            string xConvert;
            do
            {
                Console.Write("\nВведите число для x: ");
                xConvert = Console.ReadLine();
                if (double.TryParse(xConvert, out x))
                {
                    isBuff = true;
                }
                else
                {
                    Console.WriteLine("\nОшибка, нужно ввести целое число");
                }
            } while (!isBuff);
            double a = Math.Abs(x);
            double a1 = Math.Sqrt(a);
            double a2 = Math.Pow(a1, 4);
            double a3 = Math.Sqrt(x + a2);
            double answer = Math.Pow(2, -x) * a3;
            Console.WriteLine("\n2^(-" + x + ") * sqrt(" + x + " + sqrt(abs(" + x + "))^4) = " + answer);
            Console.ReadLine();
        }
    }
}
