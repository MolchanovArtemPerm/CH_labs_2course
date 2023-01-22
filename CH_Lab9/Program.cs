using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace CH_Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №9");
            Time t = new Time();
            Time temp = new Time();
            int hoursTemp = 0; int minutesTemp = 0; int sizeArr = 0;

            //Создание 1 времени
            Console.WriteLine("\nСоздание первого времени");
            hoursTemp = Program.GetInt("\nВведите значение часов: ", "Ошибка, нужно ввести целое число!", (int num) => num >= 0);
            minutesTemp = Program.GetInt("\nВведите значение минут: ", "Ошибка, нужно ввести целое число!", (int num) => num >= 0);

            // Добавление методом
            t.Add(hoursTemp, minutesTemp);
            Console.WriteLine("");
            t.Print(); // Вывод времени

            // Создание второго времени
            Console.WriteLine("\nСоздание второго времени");
            hoursTemp = Program.GetInt("\nВведите значение часов: ", "Ошибка, нужно ввести целое число!", (int num) => num >= 0);
            minutesTemp = Program.GetInt("\nВведите значение минут: ", "Ошибка, нужно ввести целое число!", (int num) => num >= 0);

            Console.WriteLine("");
            temp.Add(hoursTemp, minutesTemp); // Добавление 2 времени
            temp.Print(); // Вывод 2 времени

            Console.Write("\nВычитание 1 времени из 2: ");
            t.Subtraction(temp); // Вычитание времени из времени

            Console.WriteLine($"\nСчетчик создания времени: {t.GetCount()}"); // Счетчик создания времен

            // Унарное прибавление
            t++;
            Console.Write($"\nВремя после унарного прибавления минуты: ");
            t.Print();

            // Унарное вычитание
            t--;
            Console.Write($"\nВремя после унарного вычитания минуты: ");
            t.Print();

            // Сравнение большего к меньшему
            Console.WriteLine($"\nВремя {t.Hours}:{t.Minutes} больше чем время {temp.Hours}:{temp.Minutes}: {t > temp}");

            // Сравнение меньшего к большему
            Console.WriteLine($"\nВремя {t.Hours}:{t.Minutes} меньше чем время {temp.Hours}:{temp.Minutes}: {t < temp}");

            // Неявное преобразование, всего минут
            int allMin = t;
            Console.WriteLine($"\nВремя {t.Hours}:{t.Minutes} в минутах: {allMin}\n");

            // Явное преобразование, проверка на 0
            bool f = (bool)t;
            if (f)
            {
                Console.WriteLine("Время больше 0");
            }
            else
            {
                Console.WriteLine("Время равно 0");
            }

            // Создание массива времени
            Console.WriteLine("\nСоздание массива времени");
            sizeArr = Program.GetInt("\nВведите размер массива: ", "Размер не может быть отрицательным!", (int num) => num >= 0);

            TimeArray arr = new TimeArray(sizeArr);
            Time[] list = new Time[sizeArr];

            for (int i = 0,k = 1; i < sizeArr; i++,k++)
            {
                Time newtime = new Time();
                newtime.Clear();
                hoursTemp = Program.GetInt($"\nВведите значение часов для {k} времени: ", "Ошибка, нужно ввести целое число!", (int num) => num >= 0);
                minutesTemp = Program.GetInt($"\nВведите значения минут для {k} времени: ", "Ошибка, нужно ввести целое число!", (int num) => num >= 0);

                newtime.Add(hoursTemp,minutesTemp);
                if (list[i] == null)
                {
                    list[i] = newtime;
                }
            }

            arr.Arr = list; // Добавляем лист времени в массив
            Console.WriteLine("\nМассив времени:");
            arr.Print(); // Выводим массив

            // Находим максимальное значение времени
            Time Maximus = new Time();
            Console.Write("\nМаксимальное значение времени: ");
            Maximus = arr.Maximum();
            Maximus.Print(); // Вывод максимального значения
            Console.Write($"Под номером: {arr.Get_id()}");
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
                {
                    Console.Write(errorMessage);
                }
            } while (!isCorrect);
            return result;
        }
    }
}
