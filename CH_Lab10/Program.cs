using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//22 % 17 = 5  Вариант
namespace CH_Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface.start();
        }
        public static int GetInt(string inputMessage, string errorMessage, Predicate<int> condition)
        {
            int result;
            bool isCorrect;
            do
            {
                Console.Write(inputMessage);
                isCorrect = int.TryParse(Console.ReadLine(), out result) && condition(result);
                if (!isCorrect)
                    ColorDisplay(errorMessage, ConsoleColor.Red);
            } while (!isCorrect);
            return result;
        }

        //цветной вывод текста в консоль
        public static void ColorDisplay(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
