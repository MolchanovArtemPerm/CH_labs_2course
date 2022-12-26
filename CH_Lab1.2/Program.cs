using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH_Lab1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1.2");
            string x1, y1;
            float x, y;
            bool isConvert;
            do
            {
                Console.Write("\nВведите координату x: ");
                x1 = Console.ReadLine();
                isConvert = float.TryParse(x1, out x);
                if (!isConvert)
                    Console.WriteLine("\nОшибка, нужно ввести число");
            } while (!isConvert);
            do
            {
                Console.Write("\nВведите координату y: ");
                y1 = Console.ReadLine();
                isConvert = float.TryParse(y1, out y);
                if (!isConvert)
                    Console.WriteLine("\nОшибка, нужно ввести число");
            } while (!isConvert);
            bool isAnswer1 = ((y - (5f / 7f) * x) <= -7f && x <= 0f && y >= 0f);
            bool isAnswer2 = ((y + (5d / 7d) * x) >= -5d && x <= 0d && y >= 0d);
            bool isAnswer3 = ((y - (5f / 3f) * x) >= -5f && x >= 0f && y <= 0f);
            Console.WriteLine("\nПроверка №1 = " + isAnswer1 + "\nПроверка №2 = " + isAnswer2 + "\nПроверка №3 = " + isAnswer3);
            if((isAnswer1 || isAnswer2 || isAnswer3) == true)
            {
                Console.WriteLine("\n" + (isAnswer1 || isAnswer2 || isAnswer3) + ", точка входит в область графика");

            }
            else
            {
                Console.WriteLine("\n" + (isAnswer1 || isAnswer2 || isAnswer3) + ", точка не входит в область графика");

            }
            Console.ReadLine();
        }
    }
}
