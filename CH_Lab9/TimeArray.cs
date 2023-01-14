using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH_Lab9
{
    public class TimeArray
    {
        
        private Time[] arr;
        private int lenght_arr;
        private static int id;
        public int Lenght
        {
            get
            {
                return lenght_arr;
            }
        }
        public int Get_id() { return id; }
        public Time[] Arr
        {
            get
            {
                return arr;
            }
            set
            {
                arr = value;
            }
        }
        public Time Maximum()
        {
            int size = lenght_arr;
            id = 0;
            Time max = new Time();
            max.Add(arr[0].Hours, arr[0].Minutes);
            if (size == 0)
            {
                Console.WriteLine("Массив пустой");
            }
            for (int i = 0; i < size; i++)
            {
                if (arr[i] > max)
                {
                    max.Clear();
                    max.Add(arr[i].Hours, arr[i].Minutes);
                    id = i;
                }
            }
            id++; // Для номера
            return max;
        }
        public TimeArray(int size)
        {
            lenght_arr = size;
            Random rnd = new Random();
            arr = new Time[lenght_arr];
            for (int i = 0; i < lenght_arr; i++)
            {
                arr[i]=new Time();
            }
    
        }
        public TimeArray(Time[] list)
        { 
            lenght_arr = list.Length;
            arr = new Time[lenght_arr];
            for (int i = 0; i < lenght_arr; i++)
            {
                arr[i] = list[i];
            }
        }
        public void Print()
        {
            for (int i = 0, k = 1; i < lenght_arr; i++, k++) 
            { 
                Console.WriteLine($"Время под номером {k}: {arr[i].Hours}:{arr[i].Minutes}"); 
            }
        }
        public TimeArray()
        {
            lenght_arr = 0;
            arr = new Time[lenght_arr];
        }
        public Time this[int index]
        {
            get
            {
                try
                {
                    return arr[index];
                }
                catch(Exception e) 
                { 
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
            set
            {
                if (index < 0 || index >= arr.Length)
                {
                    Console.WriteLine("Такого индекса нет!");
                }
                else
                arr[index] = value; 
            }
        }
    }
}
