using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH_Lab10
{
    public class Test : Trial
    {
        protected static readonly string[] tests = { "Физика", "Математика", "Английский", "Русский язык", "Биология","Химия","Информатика" };
        public string name_test { get; protected set; }

        public Test()
        {
            this.RandomInit();
        }
        public Test(string subject_surname, string subject_name, float result,string name_test) : base(subject_surname, subject_name, result)
        {
            this.name_test = name_test;
        }
        public override string ToString()
        {
            return $"Ученик: {subject_surname} {subject_name}" +
                $", Отметка: {result}" +
                $", Экзамен по: {name_test}";
        }
        public override object Clone()
        {
            return new Test(this.subject_surname, this.subject_name , this.result, this.name_test);
        }
        public override void RandomInit()
        {
            Random rnd = new Random();
            this.subject_surname = surname[rnd.Next(0, surname.Length)];
            System.Threading.Thread.Sleep(5);
            this.subject_name = name[rnd.Next(0, name.Length)];
            System.Threading.Thread.Sleep(5);
            this.result = marks[rnd.Next(0, marks.Length - 1)];
            System.Threading.Thread.Sleep(5);
            this.name_test = tests[rnd.Next(0,tests.Length - 1)];
        }
    }
}
