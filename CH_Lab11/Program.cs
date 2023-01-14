using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CH_Lab11
{
    class Program
    {
        public const int MIN_LENGTH = 4;
        public const int MAX_LENGTH = 6;
        static void Main(string[] args)
        {
            UserInterface.execute();
            return;
        }

        // Генерация сортированного словаря с помощью ГСЧ
        public static Dictionary<Trial, Test> GenerateDictionary()
        {
            Random rnd = new Random();
            int len = rnd.Next(MIN_LENGTH, MAX_LENGTH);
            Dictionary<Trial, Test> trials = new Dictionary<Trial, Test>();
            for (int i = 0; i < len; ++i)
            {
                try
                {
                    switch (rnd.Next(0, 3))
                    {
                        case 0:
                            Test test = new Test();
                            trials.Add(test.BaseTrial, test);
                            break;
                        case 1:
                            Exam exam = new Exam();
                            trials.Add(exam.BaseTrial, exam);
                            break;
                        case 2:
                            ExamOut examout = new ExamOut();
                            trials.Add(examout.BaseTrial, examout);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    ColorDisplay("Ошибка генерации: " + ex.Message + "\n", ConsoleColor.Red);
                    continue;
                }
            }
            return trials;
        }
        // Отображение сортированного словаря
        public static void DisplayDictionary(Dictionary<Trial, Test> trials)
        {
            if (trials.Count != 0)
            {
                int counter = 1;
                foreach (var trial in trials)
                {
                    ColorDisplay($"{counter++}. Ключ: ", ConsoleColor.Blue);
                    Console.Write(trial.Key);
                    ColorDisplay("\nЗначение: ", ConsoleColor.Magenta);
                    Console.WriteLine(trial.Value.ToString() + '\n');
                }
            }
            else
            {
                ColorDisplay("Словарь пуст!\n", ConsoleColor.Red);
            }
        }
        // Отображение определённого типа из словаря
        public static void DisplayTypeInDictionary(Dictionary<Trial, Test> trials, Type t)
        {
            int counter = 0;
            int index = 0;
            if (t == typeof(Test))
            {
                ColorDisplay("Элементы типа Test:\n", ConsoleColor.Yellow);
                foreach (var emp in trials)
                {
                    if (emp.Value != null && (emp.Value is Test) && !(emp.Value is Exam) && !(emp.Value is ExamOut))
                    {
                        Console.WriteLine(index.ToString() + ". " + emp.Value.ToString());
                        ++counter;
                    }
                    ++index;
                }
                Console.WriteLine("Кол-во элементов типа Test: " + counter);
            }
            else if (t == typeof(Exam))
            {
                ColorDisplay("Элементы типа Exam:\n", ConsoleColor.Yellow);
                foreach (var eng in trials)
                {
                    if (eng.Value != null && (eng.Value is Exam))
                    {
                        Console.WriteLine(index.ToString() + ". " + eng.Value.ToString());
                        ++counter;
                    }
                    ++index;
                }
                Console.WriteLine("Кол-во элементов типа Exam: " + counter);
            }
            else if (t == typeof(ExamOut))
            {
                ColorDisplay("Элементы типа ExamOut:\n", ConsoleColor.Yellow);
                foreach (var adm in trials)
                {
                    if (adm.Value != null && (adm.Value is ExamOut))
                    {
                        Console.WriteLine(index.ToString() + ". " + adm.Value.ToString());
                        ++counter;
                    }
                    ++index;
                }
                Console.WriteLine("Кол-во элементов типа ExamOut: " + counter);
            }
            if (counter == 0)
            {
                ColorDisplay("Такого типа нет в коллекции!\n", ConsoleColor.Red);
            }
            return;
        }
        // Вставка случайного элемента в словарь
        public static void InsertRandomIntoDictionary(ref Dictionary<Trial, Test> trials)
        {
            Random rnd = new Random();
            try
            {
                switch (rnd.Next(0, 3))
                {
                    case 0:
                        Test test = new Test();
                        trials.Add(test.BaseTrial, test);
                        ColorDisplay($"Добавлен объект: {trials[test.BaseTrial]}\n", ConsoleColor.Cyan);
                        break;
                    case 1:
                        Exam exam = new Exam();
                        trials.Add(exam.BaseTrial, exam);
                        ColorDisplay($"Добавлен объект: {trials[exam.BaseTrial]}\n", ConsoleColor.Cyan);
                        break;
                    case 2:
                        ExamOut examout = new ExamOut();
                        trials.Add(examout.BaseTrial, examout);
                        ColorDisplay($"Добавлен объект: {trials[examout.BaseTrial]}\n", ConsoleColor.Cyan);
                        break;
                }
            }
            catch (Exception ex)
            {
                ColorDisplay("Ошибка генерации: " + ex.Message + "\n", ConsoleColor.Red);
            }
        }
        // Удаление заданного элемента из словаря
        public static void DeletePersonFromDictionary(ref Dictionary<Trial, Test> trials)
        {
            Trial key = Trial.InputTrial();
            if (trials.Remove(key))
            {
                ColorDisplay($"Объект: {key}, успешно удалён!\n", ConsoleColor.Cyan);
            }
            else
            {
                ColorDisplay("Такого ключа нет в словаре!\n", ConsoleColor.Red);
            }
        }
        public static Dictionary<Trial, Test> CopyDictionary(Dictionary<Trial, Test> trials)
        {
            var result = new Dictionary<Trial, Test>();
            foreach (var pair in trials)
            {
                result.Add((Trial)pair.Key.Clone(), (Test)pair.Value.Clone());
            }
            return result;
        }
        // Генерация с помощью ГСЧ
        public static LinkedList<Trial> GenerateLinkedList()
        {
            Random rnd = new Random();
            int len = rnd.Next(MIN_LENGTH, MAX_LENGTH);
            LinkedList<Trial> trials = new LinkedList<Trial>();
            for (int i = 0; i < len; ++i)
            {
                switch (rnd.Next(0, 4))
                {
                    case 0:
                        trials.AddLast(new Trial());
                        break;
                    case 1:
                        trials.AddLast(new Test());
                        break;
                    case 2:
                        trials.AddLast(new Exam());
                        break;
                    case 3:
                        trials.AddLast(new ExamOut());
                        break;
                }
            }
            return trials;
        }
        // Сортировка
        public static void SortLinkedList(ref LinkedList<Trial> trials)
        {
            Trial[] p = trials.ToArray();
            Array.Sort(p);
            LinkedList<Trial> result = new LinkedList<Trial>();
            for (int i = 0; i < p.Length; ++i)
            {
                result.AddLast(p[i]);
            }
            trials = result;
        }
        // Вывод
        public static void DisplayLinkedList(LinkedList<Trial> trials)
        {
            if (trials.Count != 0)
            {
                string result = "";
                int counter = 1;
                foreach (Trial p in trials)
                {
                    if (p != null)
                    {
                        result += $"\t{counter}. " + p.ToString() + '\n';
                    }
                    else
                    {
                        result += "\tNULL\n";
                    }
                    ++counter;
                }
                Console.WriteLine(result);
            }
            else
            {
                ColorDisplay("Пусто!\n", ConsoleColor.Red);
            }
        }
        // Вывод всех элементов определённого типа и их количества
        public static void DisplayTypeInLinkedList(LinkedList<Trial> Trials, Type t)
        {
            int counter = 0;
            int index = 0;
            if (t == typeof(Trial))
            {
                Console.WriteLine("Элементы типа Trial: ");
                foreach (Trial p in Trials)
                {
                    if (p != null && !(p is Test))
                    {
                        Console.WriteLine(index.ToString() + ". " + p.ToString());
                        ++counter;
                    }
                    ++index;
                }
                Console.WriteLine("Кол-во элементов типа Trial: " + counter);
            }
            else if (t == typeof(Test))
            {
                Console.WriteLine("Элементы типа Test: ");
                foreach (Trial p in Trials)
                {
                    if (p != null && p is Test && !(p is Exam) && !(p is ExamOut))
                    {
                        Console.WriteLine(index.ToString() + ". " + p.ToString());
                        ++counter;
                    }
                    ++index;
                }
                Console.WriteLine("Кол-во элементов типа Test: " + counter);
            }
            else if (t == typeof(Exam))
            {
                Console.WriteLine("Элементы типа Exam: ");
                foreach (Trial p in Trials)
                {
                    if (p != null && p is Exam)
                    {
                        Console.WriteLine(index.ToString() + ". " + p.ToString());
                        ++counter;
                    }
                    ++index;
                }
                Console.WriteLine("Кол-во элементов типа Exam: " + counter);
            }
            else if (t == typeof(ExamOut))
            {
                Console.WriteLine("Элементы типа ExamOut: ");
                foreach (Trial p in Trials)
                {
                    if (p != null && p is ExamOut)
                    {
                        Console.WriteLine(index.ToString() + ". " + p.ToString());
                        ++counter;
                    }
                    ++index;
                }
                Console.WriteLine("Кол-во элементов типа ExamOut: " + counter);

            }
            if (counter == 0)
            {
                ColorDisplay("Такого типа нет в коллекции!\n", ConsoleColor.Red);
            }
            return;
        }
        // Глубока копия
        public static LinkedList<Trial> CopyLinkedList(LinkedList<Trial> Trials)
        {

            LinkedList<Trial> result = new LinkedList<Trial>();
            foreach (Trial p in Trials)
            {
                result.AddLast((Trial)p.Clone());
            }
            return result;
        }
        // Поиск человека
        public static int FindPerson(LinkedList<Trial> trials, Trial trial)
        {
            int index = -1;
            int counter = 0;
            foreach (Trial p in trials)
            {

                if (p.Equals(trial))
                {
                    index = counter;
                    break;
                }
                counter += 1;
            }
            return index;
        }
        // Проверка ввода
        public static int GetInt(string inputMessage, string errorMessage, Predicate<int> condition)
        {
            int result;
            bool isCorrect;
            do
            {
                Console.Write(inputMessage);
                isCorrect = int.TryParse(Console.ReadLine(), out result) && condition(result);
                if (!isCorrect)
                {
                    ColorDisplay(errorMessage, ConsoleColor.Red);
                }
            } while (!isCorrect);
            return result;
        }
        public static void ColorDisplay(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
