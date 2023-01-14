using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH_Lab10
{
    static class UserInterface
    {
        public static void start()
        {
            School c = new School();
            School shallow_c = c.ShallowCopy(); //поверхностное копирование
            School deep_c = (School)c.Clone(); //глубокое копирование
            IRandomInit[] randoms = new IRandomInit[c.trials.Length + 1];
            for (int i = 0; i < randoms.Length - 1; ++i)
            {
                randoms[i] = (Trial)c.trials[i].Clone();
            }
            randoms[randoms.Length - 1] = c;


            while (true)
            {
                Console.Clear();
                Program.ColorDisplay("Номера команд:\n1. 1 часть\n2. 2 часть\n3. 3 часть\n0. Назад\n", ConsoleColor.Blue);
                int command = Program.GetInt("Введите номер команды: ", "Несуществующая команда, повторите ввод\n", (int num) => num >= 0 && num <= 3);
                Console.Clear();
                switch (command)
                {
                    case 1:
                        task1(c);
                        break;
                    case 2:
                        task2(c);
                        break;
                    case 3:
                        task3(randoms, ref c, shallow_c, deep_c);
                        break;
                    case 0:
                        return;
                }
            }
        }
        public static void task1(School c)
        {
            while (true)
            {
                Program.ColorDisplay("Номера команд:\n1. Вывод массива с помощью переопределния виртуальной функции ToString()\n" +
                   "2. Вывод массива без виртуальных функций\n" +
                   "0. Назад\n", ConsoleColor.Blue);
                int command = Program.GetInt("Введите номер команды: ", "Несуществующая команда, повторите ввод\n", (int num) => num >= 0 && num <= 2);
                switch (command)
                {
                    case 1:
                        Console.Write(c);
                        break;
                    case 2:
                        string result = $"Ученики из школы {c.number_school}:\n";
                        for (int i = 0; i < c.trials.Length; ++i)
                        {
                            if (c.trials[i] != null)
                                result += $"\t{i}. " + c.trials[i].NoVirtualToString() + '\n';
                            else
                                result += "\tNULL\n";
                        }
                        Console.Write(result);
                        break;
                    case 0:
                        return;
                }
                Program.ColorDisplay("Для продолжения нажмите любую клавишу...", ConsoleColor.Green);
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void task2(School c)
        {
            while (true)
            {
                Program.ColorDisplay("Номера команд:\n1. Ученики, сдавшие все экзамены на отлично.\n" +
                    "2. Ученики, не сдавшие хотя бы один экзамен.\n" +
                    "3. Ученики, сдавшие заданный экзамены на хорошо и отлично.\n0. Назад\n", ConsoleColor.Blue);
                Console.Write(c);
                int command = Program.GetInt("Введите номер команды: ", "Несуществующая команда, повторите ввод\n", (int num) => num >= 0 && num <= 3);
                switch (command)
                {
                    case 1:
                        School.showQuery(c.getTeenagersA());
                        break;
                    case 2:
                        School.showQuery(c.getTeenagersBad());
                        break;
                    case 3:
                        Console.Write("Введите название экзамена: ");
                        string exams = Console.ReadLine();
                        School.showQuery(c.getTeenagersAandB(exams));
                        break;
                    case 0:
                        return;
                }
                Program.ColorDisplay("Для продолжения нажмите любую клавишу...", ConsoleColor.Green);
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void task3(IRandomInit[] randoms, ref School c, School shallow_c, School deep_c)
        {
            while (true)
            {
                Program.ColorDisplay("Номера команд:\n1. Сгенерировать и вывести массив элементов IRandomInit\n" +
                    "2. Сортировка массива по ФИО с помощью интерфейса IComparable\n" +
                    "3. Сортировка массива по имени с помощью интерфейса ICompare и поиск человека с помощью перегрузки метода Equals\n" +
                    "4. Разница между поверхностным и глубоким копированием\n" +
                    "0. Назад\n", ConsoleColor.Blue);
                int command = Program.GetInt("Введите номер команды: ", "Несуществующая команда, повторите ввод\n", (int num) => num >= 0 && num <= 4); 
                switch (command)
                {
                    case 1:
                        for (int i = 0; i < randoms.Length; ++i)
                        {
                            Console.WriteLine(i.ToString() + ". " + randoms[i].ToString());
                        }
                        break;

                    case 2:
                        Console.Write(c);
                        break;
                    case 3:
                        Array.Sort(c.trials, new SortName());
                        Console.Write(c);

                        string name, surname;
                        Console.Write("Введите фамилию: ");
                        surname = Console.ReadLine();
                        Console.Write("Введите имя: ");
                        name = Console.ReadLine();
                        Program.ColorDisplay($"Индекс этого ученика в массиве: {Array.IndexOf(c.trials, new Trial(surname, name))}\n",ConsoleColor.Magenta);
                        Array.Sort(c.trials);
                        break;
                    case 4:
                        Program.ColorDisplay("Изначальный объект, переменная `c` типа School:\n", ConsoleColor.Green);
                        Console.Write(c);
                        Program.ColorDisplay("Поверхностная копия, переменная `shallow_c` типа School:\n", ConsoleColor.Green);
                        Console.Write(shallow_c);
                        Program.ColorDisplay("Глубокая копия, переменная `deep_c` типа School:\n", ConsoleColor.Green);
                        Console.Write(deep_c);
                        for (int i = 0; i < c.trials.Length; ++i)
                            c.trials[i] = null;
                        Program.ColorDisplay("Все элементы массива в переменной `c` заменены на null\n", ConsoleColor.Magenta);
                        Program.ColorDisplay("Изначальный объект, переменная `c` типа School:\n", ConsoleColor.Green);
                        Console.Write(c);
                        Program.ColorDisplay("Поверхностная копия, переменная `shallow_c` типа School:\n", ConsoleColor.Green);
                        Console.Write(shallow_c);
                        Program.ColorDisplay("Глубокая копия, переменная `deep_c` типа School:\n", ConsoleColor.Green);
                        Console.Write(deep_c);
                        c = (School)deep_c.Clone();
                        randoms[randoms.Length - 1] = c;
                        shallow_c = c.ShallowCopy();
                        break;
                    case 0:
                        return;
                }
                Program.ColorDisplay("Для продолжения нажмите любую клавишу...", ConsoleColor.Green);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
