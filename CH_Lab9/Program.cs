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
            bool isConvert = false;
            bool isFlag = false;
            string tempStr;


            //Создание 1 времени
            Console.WriteLine("\nСоздание первого времени");
            do
            {
                Console.Write("\nВведите значение часов: ");
                tempStr = Console.ReadLine();
                isFlag = int.TryParse(tempStr, out hoursTemp);
                if (hoursTemp < 0 || !isFlag)
                {
                    Console.WriteLine("Ошибка, нужно ввести целое число!");
                }
                else
                {
                    isConvert = true;
                }
            } while (!isConvert);
            isConvert = false;
            do
            {
                Console.Write("Введите значения минут: ");
                tempStr = Console.ReadLine();
                isFlag = int.TryParse(tempStr, out minutesTemp);
                if (minutesTemp < 0 || !isFlag)
                {
                    Console.WriteLine("Ошибка, нужно ввести целое число!");
                }
                else
                {
                    isConvert = true;
                }
            } while (!isConvert);
            isConvert = false;
            // Добавление методом
            t.Add(hoursTemp, minutesTemp);
            Console.WriteLine("");
            // Вывод времени
            t.Print();

            // Создание второго времени
            Console.WriteLine("\nСоздание второго времени");
            do
            {

                Console.Write("\nВведите значение часов: ");
                tempStr = Console.ReadLine();
                isFlag = int.TryParse(tempStr, out hoursTemp);
                if (hoursTemp < 0 || !isFlag)
                {
                    Console.WriteLine("Ошибка, нужно ввести целое число!");
                }
                else
                {
                    isConvert = true;
                }
            } while (!isConvert);
            isConvert = false;
            do
            {
                Console.Write("Введите значения минут: ");
                tempStr = Console.ReadLine();
                isFlag = int.TryParse(tempStr, out minutesTemp);
                if (minutesTemp < 0 || !isFlag)
                {
                    Console.WriteLine("Ошибка, нужно ввести целое число!");
                }
                else
                {
                    isConvert = true;
                }
            } while (!isConvert);
            isConvert = false;

            Console.WriteLine("");
            temp.Add(hoursTemp, minutesTemp); // Добавление 2 времени
            temp.Print();

            t.Subtraction(ref temp); // Вычитание времени из времени

            Console.Write("\nВремя после вычитания: ");
            t.Print(); // Вывод

            Console.WriteLine($"\nСчетчик создания времени: {t.GetCount()}");// Счетчик создания времен

            // Унарное прибавление
            t++;
            Console.Write($"\nВремя после унарного прибавления минуты: ");
            t.Print();

            // Унарное вычитание
            t--;
            Console.Write($"\nВремя после унарного вычитания минуты: ");
            t.Print();

            // Сравнение большего к меньшему
            Console.WriteLine($"\nВремя {t.GetHours()}:{t.GetMinutes()} больше чем время {temp.GetHours()}:{temp.GetMinutes()}: {t > temp}");

            // Сравнение меньшего к большему
            Console.WriteLine($"\nВремя {t.GetHours()}:{t.GetMinutes()} меньше чем время {temp.GetHours()}:{temp.GetMinutes()}: {t < temp}");

            // Неявное преобразование, всего минут
            int allMin = t;
            Console.WriteLine($"\nВремя {t.GetHours()}:{t.GetMinutes()} в минутах: {allMin}\n");

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
            isConvert = false;
            do
            {
                Console.Write("\nВведите размер массива: ");
                tempStr = Console.ReadLine();
                isFlag = int.TryParse(tempStr, out sizeArr);
                if (sizeArr < 0 || !isFlag)
                {
                    Console.WriteLine("размер не может быть отрицательным!");
                }
                else
                {
                    isConvert = true;
                }
            } while (!isConvert);
            TimeArray arr = new TimeArray(sizeArr);
            Time[] list = new Time[sizeArr];
            isConvert = false;
            for (int i = 0,k = 1; i < sizeArr; i++,k++)
            {
                Time newtime = new Time();
                newtime.Clear();
                do
                {
                    Console.Write($"\nВведите значение часов для {k} времени: ");
                    tempStr = Console.ReadLine();
                    isFlag = int.TryParse(tempStr, out hoursTemp);
                    if (hoursTemp < 0 || !isFlag)
                    {
                        Console.WriteLine("Время не может быть отрицательным!");
                    }
                    else
                    {
                        isConvert = true;
                    }
                } while (!isConvert);
                isConvert = false;
                do
                {
                    Console.Write($"Введите значения минут для {k} времени: ");
                    tempStr = Console.ReadLine();
                    isFlag = int.TryParse(tempStr, out minutesTemp);
                    if (minutesTemp < 0 || !isFlag)
                    {
                        Console.WriteLine("Время не может быть отрицательным!");
                    }
                    else
                    {
                        isConvert = true;
                    }
                } while (!isConvert);
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
    }
}
