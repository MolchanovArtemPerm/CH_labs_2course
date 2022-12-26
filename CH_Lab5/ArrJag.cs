using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH_Lab5
{
    internal class ArrJag
    {
        Random rnd = new Random();
        static int strings = 0, columns = 0, countAddStr = 0;
        public int[][] Arr3 = new int[strings][];
        public int[][] ArrTempJag = new int[strings][];
        public void Creat_hands()
        {
            Console.Write("\nВведите количество строк: ");
            strings = Convert.ToInt32(Console.ReadLine());
            if(strings <= 0 )
            {
                Console.WriteLine("Строка не может быть размером 0!");
            }
            else
            {
                Arr3 = new int[strings][];
                for (int i = 0, k = 0; i < strings; i++)
                {
                    Console.Write($"\nВведите количество столбцов для {++k}: ");
                    columns = Convert.ToInt32(Console.ReadLine());
                    if(columns <= 0)
                    {
                        Console.WriteLine("столбец не может быть размером 0!");
                        break;
                    }
                    else
                    {
                        Arr3[i] = new int[columns];
                        for (int j = 0, t = 0; j < columns; j++)
                        {
                            Console.WriteLine($"\nВведите значение для {k}-ой строки и {++t}-ой колонки: ");
                            Arr3[i][j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                }
            }
        }
        public void Creat_DSCH()
        {
            Console.Write("\nВведите количество строк: ");
            strings = Convert.ToInt32(Console.ReadLine());
            if (strings <= 0 )
            {
                Console.WriteLine("Строка не может быть размером 0!");
            }
            else
            {
                Arr3 = new int[strings][];
                for (int i = 0, k = 0; i < strings; i++)
                {
                    Console.Write($"\nВведите количество столбцов для {++k}: ");
                    columns = Convert.ToInt32(Console.ReadLine());
                    if (columns <= 0)
                    {
                        Console.WriteLine("столбец не может быть размером 0!");
                        break;
                    }
                    else
                    {
                        Arr3[i] = new int[columns];
                        for (int j = 0; j < columns; j++)
                        {
                            Arr3[i][j] = rnd.Next(0, 50);
                        }
                    }

                }
            }
        }
        public void Print()
        {
            if (strings <= 0)
            {
                Console.WriteLine("\nМассив пуст.");
            }
            else
            {
                Console.Write("\nРваный массив: ");
                for (int i = 0; i < strings; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < Arr3[i].Length; j++)
                    {
                        Console.Write(Arr3[i][j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }


        public void Add()
        {
            Console.Write("\nВведите количество добавленых строк: ");
            countAddStr = Convert.ToInt32(Console.ReadLine());
            if(countAddStr <= 0)
            {
                Console.WriteLine("Операция прервана, вы пытаетесь добавить 0 строк!");
            }
            else
            {
                strings += countAddStr;
                ArrTempJag = new int[strings][];
                for (int i = 0, k = Arr3.Length, temp = 0; i < strings; i++)
                {
                    if (i == Arr3.Length)
                    {
                        for (int countFor = 1; countFor <= countAddStr; countFor++)
                        {
                            Console.Write($"\nВведите количество столбцов для {k}: ");
                            columns = Convert.ToInt32(Console.ReadLine());
                            if(columns <= 0)
                            {
                                Console.WriteLine("Вы не можете добавить 0 столбцов!");
                            }
                            else
                            {
                                ArrTempJag[i] = new int[columns];
                                for (int j = 0, t = 0; j < ArrTempJag[i].Length; j++)
                                {
                                    Console.WriteLine($"\nВведите значение для {k}-ой строки и {++t}-ой колонки: ");
                                    ArrTempJag[i][j] = Convert.ToInt32(Console.ReadLine());
                                }
                                k++;
                                i++;
                            }
                        }
                    }
                    else
                    {
                        ArrTempJag[i] = new int[Arr3[i].Length];
                        for (int j = 0; j < Arr3[i].Length; j++)
                        {
                            ArrTempJag[i][j] = Arr3[temp][j];
                        }
                        temp++;
                    }
                }
                Arr3 = new int[strings][];
                for (int i = 0; i < strings; i++)
                {
                    Arr3[i] = new int[ArrTempJag[i].Length];
                    for (int j = 0; j < ArrTempJag[i].Length; j++)
                    {
                        Arr3[i][j] = ArrTempJag[i][j];
                    }
                }
            }
        }

        public int Size()
        {
            return Arr3.Length;
        }
    }
}
