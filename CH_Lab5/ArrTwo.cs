using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH_Lab5
{
    internal class ArrTwo
    {
        Random rnd = new Random();
        static int strings = 0, columns = 0, countAddStr = 0, addStr = 0;
        public int[,] Arr2 = new int[strings, columns];
        public int[,] ArrTwoTemp = new int[strings, columns];
        public void Creat_hands()
        {
            Console.WriteLine("\nВведите количество строк:");
            strings = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов:");
            columns = Convert.ToInt32(Console.ReadLine());
            if(strings <= 0 || columns <= 0)
            {
                Console.WriteLine("Количество строк и столбцов не может быть 0!");
            }
            else
            {
                Arr2 = new int[strings, columns];
                for (int i = 0, k = 0; i < strings; i++)
                {
                    for (int j = 0, t = 0; j < columns; j++)
                    {
                        Console.WriteLine($"Введите значение для {++k}-ой строки и {++t}-ой колонки:");
                        Arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
        }
        public void Creat_DSCH()
        {
            Console.Write("\nВведите количество строк: ");
            strings = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            columns = Convert.ToInt32(Console.ReadLine());
            if (strings <= 0 || columns <= 0)
            {
                Console.WriteLine("Количество строк и столбцов не может быть 0!");
            }
            else
            {
                Arr2 = new int[strings, columns];
                for (int i = 0; i < strings; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Arr2[i, j] = rnd.Next(1, 50);
                    }
                }
            }
            
        }
        public void Print()
        {
            if (strings <= 0 || columns <= 0)
            {
                Console.WriteLine("\nМассив пуст.");
            }
            else
            {
                Console.WriteLine("\nДвумерный массив:");
                for (int i = 0; i < strings; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(Arr2[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        public void Add()
        {
            if (strings <= 0 || columns <= 0)
            {
                Console.WriteLine("Операция провалена, двумерный массив пуст");
            }
            else
            {
                Console.Write("\nВведите количество добавленых строк: ");
                countAddStr = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Введите строку после которой добавить {countAddStr} строк: ");
                addStr = Convert.ToInt32(Console.ReadLine());
                strings += countAddStr;
                ArrTwoTemp = new int[strings, columns];
                for (int i = 0, k = 0, strok = countAddStr + 1; i < strings; i++)
                {
                    if (i == addStr)
                    {
                        for (int countFor = 1; countFor <= countAddStr; countFor++)
                        {
                            for (int j = 0, stolb = 1; j < columns; j++, stolb++)
                            {
                                Console.WriteLine($"Введите значение для {strok}-ой строки и {stolb}-ой колонки: ");
                                ArrTwoTemp[i, j] = Convert.ToInt32(Console.ReadLine());
                            }
                            i++;
                        }
                        i--;
                    }
                    else
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            ArrTwoTemp[i, j] = Arr2[k, j];
                        }
                        k++;
                    }
                }
                Arr2 = new int[strings, columns];
                for (int i = 0; i < strings; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Arr2[i, j] = ArrTwoTemp[i, j];
                    }
                }
            }
        }
    }
}
