using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CH_Lab10
{
    public class School : ICloneable, IRandomInit
    {
        public int number_school { get; private set; }
        public Trial[] trials { get; set; }
        public School()
        {
            this.RandomInit();
        }
        public static Trial[] getTrials()
        {
            Random rnd = new Random();
            Trial[] trials = new Trial[rnd.Next(10, 15)];
            for(int i = 0; i < trials.Length; i++)
            {
                switch (rnd.Next(0, 4))
                {
                    case 0:
                        trials[i] = new Trial();
                        break;
                    case 1:
                        trials[i] = new Test();
                        break;
                    case 2:
                        trials[i] = new Exam();
                        break;
                    case 3:
                        trials[i] = new ExamOut();
                        break;
                }
            }
            return trials;
        }
        public override string ToString()
        {
            string print = $"Ученики из школы {this.number_school}:\n";
            for (int i = 0, k = 1; i < trials.Length; ++i,k++)
            {
                if (trials[i] != null)
                    print += $"\t{k}. " + trials[i].ToString() + '\n';
                else
                    print += "\tNULL\n";
            }
            return print;
        }
        public void RandomInit()
        {
            Random rnd = new Random();
            this.number_school = rnd.Next(0, 100);
            this.trials = getTrials();
            Array.Sort(this.trials);
        }
        public object Clone()
        {
            School n_school = new School();
            n_school.number_school = this.number_school;
            Trial[] n_trials = new Trial[this.trials.Length];
            for(int i = 0;i < n_trials.Length; i++)
            {
                n_trials[i] = (Trial)trials[i].Clone();
            }
            n_school.trials = n_trials;
            return n_school;
        }
        // Возвращает всех учеников сдавших экзамены на отлично
        public List<Trial> getTeenagersA()
        {
            List<Trial> l_p = new List<Trial>();
            for (int i = 0; i < trials.Length; ++i)
            {
                if (trials[i] is Trial && trials[i].result == 5)
                {
                    l_p.Add(trials[i]);
                }

            }
            return l_p;
        }
        // Возвращает всех учеников не сдавших один и более экзаменов 
        public List<Trial> getTeenagersBad()
        {
            List<Trial> l_p = new List<Trial>();
            for (int i = 0; i < trials.Length; ++i)
            {
                if (trials[i] is Trial && trials[i].result == 2)
                {
                    l_p.Add(trials[i]);
                }

            }
            return l_p;
        }
        // Возвращает всех учеников, сдавших заданный экзамены на хорошо и отлично
        public List<Trial> getTeenagersAandB(string exams)
        {
            List<Trial> l_p = new List<Trial>();
            for (int i = 0; i < trials.Length; ++i)
            {
                if (trials[i] is Exam && ((Exam)trials[i]).name_test == exams && ((Trial)trials[i]).result >= 4)
                {
                    l_p.Add(trials[i]);
                }
            }
            return l_p;
        }
        public School ShallowCopy()
        {
            return (School)this.MemberwiseClone();
        }
        public static void showQuery(List<Trial> trials)
        {
            if (trials.Count != 0)
            {
                Program.ColorDisplay("Результаты запроса:\n", ConsoleColor.Yellow);
                foreach (Trial t in trials)
                {
                    Console.WriteLine('\t' + t.ToString());
                }
                return;
            }
            else
            {
                Program.ColorDisplay("Результаты запроса: таких учеников нет!\n", ConsoleColor.Magenta);
                return;
            }
        }
    }
}
