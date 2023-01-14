using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH_Lab10
{
    public class Trial : IRandomInit, IComparable<Trial>, ICloneable
    {
        protected static readonly string[] surname = { "Молчанов", "Мазунин", "Возисов", "Иванов", "Кузнецов", "Глазырин", "Власов", "Омутных", "Воронин", "Валишин", "Хаирназов", "Кудайбергенов", "Абдимиталипов" };
        protected static readonly string[] name = { "Артем", "Иван", "Егор", "Дима", "Максим", "Павел", "Сережа", "Олег", "Тимур", "Даниил", "Данил", "Даирбек", "Мирислам","Ренат"};
        protected static readonly int[] marks = { 5, 4, 3, 2 };
        public string subject_name { get; protected set; }
        public string subject_surname { get; protected set; }
        public float result { get; protected set; }

        public Trial()
        {
            this.RandomInit();
        }
        public Trial(string subject_surname, string subject_name, float result)
        {
            this.subject_name = subject_name;
            this.subject_surname = subject_surname;
            this.result = result;
        }
        public Trial(string subject_surname, string subject_name)
        {
            this.subject_name = subject_name;
            this.subject_surname = subject_surname;
        }
        public override string ToString()
        {
            return $"Ученик: {subject_surname} {subject_name}, Отметка: {result}";
        }
        public string NoVirtualToString()
        {
            return $"Ученик: {subject_surname} {subject_name}, Отметка: {result}";
        }
        public int CompareTo(Trial t)
        {
            return string.Compare(this.subject_surname + this.subject_name + this.result,t.subject_surname + t.subject_name +t.result);
        }
        public virtual object Clone()
        {
            return new Trial(this.subject_surname, this.subject_name, this.result);
        }
        public virtual void RandomInit()
        {
            Random rnd = new Random();
            this.subject_surname = surname[rnd.Next(0,surname.Length)];
            System.Threading.Thread.Sleep(5);
            this.subject_name = name[rnd.Next(0, name.Length)];
            System.Threading.Thread.Sleep(5);
            this.result = marks[rnd.Next(0, marks.Length)];
        }
        public override bool Equals(object obj)
        {
            return (obj is Trial && ((Trial)obj).subject_surname == this.subject_surname &&
                ((Trial)obj).subject_name == this.subject_name && ((Trial)obj).result == this.result);
        }
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
