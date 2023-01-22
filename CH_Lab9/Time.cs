using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CH_Lab9
{
    public class Time
    {
        private int hours;
        private int minutes;
        private static int count = 0;

        public Time()
        {
            hours = 0; minutes = 0;
            count++;
        }
        public Time(int h, int m)
        {
            if (h < 0 & m < 0)
            {
                Console.WriteLine("Часы/Минуты не могут быть отрицательными");
            }
            else
            {
                hours = h; minutes = m;
                while (m >= 60)
                {
                    hours++;
                    minutes -= 60;
                }
            }
        }
        public Time(Time t)
        {
            hours = t.hours; minutes = t.minutes;
        }
        public void Add(int h,int m)
        {
            if (h < 0 & m < 0)
            {
                Console.WriteLine("Часы/Минуты не могут быть отрицательными");
            }
            else
            {
                hours += h; minutes += m;
                while (minutes >= 60)
                {
                    hours++;
                    minutes -= 60;
                }
            }
        }
        public void Clear()
        {
            hours = 0; minutes = 0; count = 0;
        }
        public int GetCount()
        {
            return count;
        }
        public int Hours
        {
            get
            {
                return hours;
            }
            set
            {
                hours = value;
            }
        }
        public int Minutes
        {
            get
            {
                return minutes;
            }
            set
            {
                if (value > 0 && value < 60)
                    minutes = value;
                else
                {
                    if (value < 0)
                        minutes = 0;
                    else
                    {
                        hours = hours + value / 60;
                        minutes = value % 60;
                    }
                }
            }
        }
        public void Subtraction(Time t)
        {
            int allmin = (hours * 60) + minutes;
            int allmin2 = (t.hours * 60) + t.minutes;
            if (allmin > allmin2)
            {
                t.minutes += t.hours * 60;
                t.hours = 0;
                minutes += hours * 60;
                hours = 0;
                minutes -= t.minutes;
                hours = minutes / 60;
                minutes %= 60;
                t.hours = t.minutes / 60;
                t.minutes %= 60;
                Console.Write("\nВремя после вычитания: ");
                Print();
            }
            else
            {
                Console.WriteLine("\nОперация невозможна!\nВы пытаетесь вычести из меньшего времени большее.");
            }
        }
        public void Print()
        {
            if (hours > 9 && minutes > 9)
            {
                Console.WriteLine($"{hours}:{minutes} ");
            }
            else
            {
                if (hours > 9 && minutes < 10)
                {
                    Console.WriteLine($"{hours}:0{minutes}");
                }
                if (hours < 10 && minutes < 10)
                {
                    Console.WriteLine($"0{hours}:0{minutes}");
                }
                if (hours < 10 && minutes > 9)
                {
                    Console.WriteLine($"0{hours}:{minutes}");
                }
            }
        }
        public static Time operator ++(Time t)
        {
            t.minutes++;
            if(t.minutes >= 60 )
            {
                t.hours++;
                t.minutes -= 60;
            }
            return t;
        }
        public static Time operator --(Time t)
        {
            t.minutes--;
            if(t.minutes < 0 )
            {
                if(t.hours > 0)
                {
                    t.hours--;
                    t.minutes += 60;
                }
                else
                {
                    Console.WriteLine("\nНельзя произвести операцию!");
                }
            }
            return t;
        }
        public static bool operator <(Time a, Time b)
        {
            int aMinutes, bMinutes;
            aMinutes = a.minutes; aMinutes += (a.hours * 60);
            bMinutes = b.minutes; bMinutes += (b.hours * 60);
            return aMinutes < bMinutes;
        }
        public static bool operator >(Time a, Time b)
        {
            int aMinutes, bMinutes;
            aMinutes = a.minutes; aMinutes += (a.hours * 60);
            bMinutes = b.minutes; bMinutes += (b.hours * 60);
            return aMinutes > bMinutes;

        }
        public static implicit operator int(Time t)
        {
            Time all = new Time();
            all.minutes = t.minutes;
            all.minutes += (t.hours * 60);
            return all.minutes;
        }
        public static explicit operator bool(Time t)
        {
            bool isFlag;
            if(t.hours != 0 || t.minutes != 0)
            {
                isFlag = true;
            }
            else
            {
                isFlag = false;
            }
            return isFlag;
        }
    }
}
