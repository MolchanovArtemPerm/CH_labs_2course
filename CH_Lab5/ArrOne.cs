using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH_Lab5
{
    internal class ArrOne
    {
        static int sizeOne = 0;
        private int temp = 0;
        public int[] Arr = new int[sizeOne];
        private int[] ArrTemp = new int[sizeOne];
        Random rnd = new Random();
        public void Creat_hands()
        {
            Console.Write("\nВведите количество строк: ");
            sizeOne = Convert.ToInt32(Console.ReadLine());
            if(sizeOne <= 0)
            {
                Console.WriteLine("Количество строк не может быть 0!");
            }
            else
            {
                Arr = new int[sizeOne];
                ArrTemp = new int[sizeOne];
                for (int i = 0, k = 0; i < Arr.Length; i++)
                {
                    Console.Write($"Введите значение для {++k}-ой ячейки: ");
                    Arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void Creat_DSCH()
        {
            Console.Write("\nВведите количество строк: ");
            sizeOne = Convert.ToInt32(Console.ReadLine());
            if (sizeOne <= 0)
            {
                Console.WriteLine("Количество строк не может быть 0!");
            }
            else
            {
                Arr = new int[sizeOne];
                ArrTemp = new int[sizeOne];
                for (int i = 0; i < Arr.Length; i++)
                {
                    Arr[i] = rnd.Next(1, 50);
                }
            }
        }
        public void Print()
        {
            if(sizeOne <= 0)
            {
                Console.WriteLine("\nМассив пуст.");
            }
            else
            {
                Console.Write("\nОдномерный массив: ");
                for (int i = 0; i < sizeOne; i++)
                {
                    Console.Write(Arr[i] + " ");
                }
                Console.WriteLine();
            }            
        }
        public void Del()
        {
            if(sizeOne <= 0)
            {
                Console.WriteLine("Количество строк не может быть 0 и меньше!");
            }
            else
            {
                temp = 0;
                for (int i = 0,j = 0; i < Arr.Length; i++)
                {
                    if (Arr[i] % 2 != 0)
                    {
                        ArrTemp[j] = Arr[i];
                        j++;
                    }
                    else
                    {
                        temp++;
                    }
                }
                sizeOne -= temp;
                Arr = new int[sizeOne];
                for (int i = 0; i < Arr.Length; i++)
                {
                    Arr[i] = ArrTemp[i];
                }
            }
        }
    }
}
