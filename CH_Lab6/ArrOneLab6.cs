using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH_Lab6
{
    internal class ArrOneLab6
    {
        static int sizeOne = 0;
        private int minCount = 0;
        private int[] temp = new int[sizeOne];
        private int[] temp2 = new int[sizeOne];
        public int[] Arr = new int[sizeOne];
        Random rnd = new Random();
        public void Creat_hands()
        {
            Console.Write("\nВведите количество строк: ");
            sizeOne = Convert.ToInt32(Console.ReadLine());
            if (sizeOne <= 0)
            {
                Console.WriteLine("Количество строк не может быть 0!");
            }
            else
            {
                temp = new int[sizeOne];
                Arr = new int[sizeOne];
                temp2 = new int[sizeOne];
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
                temp2 = new int[sizeOne];
                temp = new int[sizeOne];
                for (int i = 0; i < Arr.Length; i++)
                {
                    Arr[i] = rnd.Next(1, 50);
                }
            }
        }
        public void Print()
        {
            if (sizeOne <= 0)
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
        public void FindMin()
        {

            if (sizeOne <= 0)
            {
                Console.WriteLine("Операция прервана, массив пуст!");
            }
            else
            {
                minCount = Arr[0];
                for (int i = 1; i < Arr.Length; i++)
                {
                    if (minCount > Arr[i])
                    {
                        minCount = Arr[i];
                    }
                }
            }
        }
        public void FindIndex()
        {
            for (int i = 0, j = 0; i < Arr.Length; i++)
            {
                if (Arr[i] % minCount == 0)
                {
                    temp[j] = Arr[i];
                    j++;
                }
            }
        }
        public void DelIndex()
        {
            int countSize = 0;
            for (int i = 0,j = 0; i < Arr.Length; i++)
            {
                if (i == temp[j])
                {
                    countSize++;
                }
                else
                {
                    temp2[i] = Arr[i];
                }
                sizeOne -= countSize;
            }
            if (sizeOne == 0)
            {
                Arr = new int[sizeOne];
            }
            else
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    Arr[i] = temp2[i];
                }
            }
            
            
        }
    }
}
