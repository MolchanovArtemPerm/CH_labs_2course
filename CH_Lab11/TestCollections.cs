using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CH_Lab11.Program;

namespace CH_Lab11
{
    internal class TestCollections
    {
        public const int MIN_LENGTH = 3;  //включительно
        public const int MAX_LENGTH = 10;  //не включительно
        public LinkedList<Trial> TrialLinked { get; set; }
        public LinkedList<string> StringLinked { get; set; }
        public Dictionary<Trial, Test> TrialDict { get; set; }
        public Dictionary<string, Test> StringDict { get; set; }
        public TestCollections(int len)
        {
            TrialLinked = new LinkedList<Trial>();
            StringLinked = new LinkedList<string>();
            TrialDict = new Dictionary<Trial, Test>();
            StringDict = new Dictionary<string, Test>();
            for (int i = 0; i < len; ++i)
            {
                try
                {
                    Test tests = new Test();
                    TrialDict.Add(tests.BaseTrial, tests);
                }
                catch
                {
                    --i;
                    continue;
                }
            }
            foreach (var trials in TrialDict)
            {
                TrialLinked.AddLast(trials.Key);
                StringLinked.AddLast(trials.Key.ToString());
                StringDict.Add(trials.Key.ToString(), trials.Value);
            }
        }
        public void Display()
        {
            ColorDisplay("LinkedList<Trial>:\n", ConsoleColor.Yellow);
            DisplayLinkedList(TrialLinked);

            ColorDisplay("Dictionary<Trial, Test>:\n", ConsoleColor.Yellow);
            DisplayDictionary(TrialDict);
        }
        public void RunTests()
        {
            if (TrialDict.Count != 0)
            {
                Test[] tests = new Test[TrialDict.Count];
                TrialDict.Values.CopyTo(tests, 0);

                Test emp = tests[0];
                ColorDisplay($"Первый элемент коллекций: {emp}\n", ConsoleColor.Yellow);
                GetMeasurements(emp);

                emp = tests[tests.Length / 2];
                ColorDisplay($"Элемент из середины коллекций: {emp}\n", ConsoleColor.Yellow);
                GetMeasurements(emp);

                emp = tests[tests.Length - 1];
                ColorDisplay($"Элемент из конца коллекций: {emp}\n", ConsoleColor.Yellow);
                GetMeasurements(emp);

                emp = new Test("NOVALUE", "NOVALUE", int.MinValue, "NOVALUE");
                ColorDisplay($"Несуществующий элемент: \n", ConsoleColor.Yellow);
                GetMeasurements(emp);
            }
            else
            {
                ColorDisplay("Нельзя запустить тестирование для коллекций без элементов!\n", ConsoleColor.Red);
            }
        }
        private void GetMeasurements(Test emp)
        {
            Stopwatch stopWatch = new Stopwatch();
            TimeSpan ts;
            bool isFind;

            Trial trials = emp.BaseTrial;
            string trialsStr = trials.ToString();

            Console.Write("Объект найден в коллекции LinkedList<trial>: ");
            stopWatch.Start();
            isFind = TrialLinked.Contains(trials);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine(isFind.ToString() + ", время поиска: [" + ts.Ticks + "] такта");
            stopWatch.Reset();

            Console.Write("Объект найден в коллекции LinkedList<string>: ");
            stopWatch.Start();
            isFind = StringLinked.Contains(trialsStr);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine(isFind.ToString() + ", время поиска: [" + ts.Ticks + "] такта");
            stopWatch.Reset();

            Console.Write("Объект найден по ключу в коллекции Dictionary<Trial, Test>: ");
            stopWatch.Start();
            isFind = TrialDict.ContainsKey(trials);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine(isFind.ToString() + ", время поиска:  [" + ts.Ticks + "] такта");
            stopWatch.Reset();

            Console.Write("Объект найден по ключу в коллекции Dictionary<string, Test>: ");
            stopWatch.Start();
            isFind = StringDict.ContainsKey(trialsStr);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine(isFind.ToString() + ", время поиска: [" + ts.Ticks + "] такта");
            stopWatch.Reset();

            Console.Write("Объект найден по значению в коллекции Dictionary<Trial, Test>: ");
            stopWatch.Start();
            isFind = StringDict.ContainsValue(emp);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine(isFind.ToString() + ", время поиска: [" + ts.Ticks + "] такта");
            stopWatch.Reset();
        }
        public void AddRandom()
        {
            Test tests = new Test();
            try
            {
                TrialDict.Add(tests.BaseTrial, tests);
                StringLinked.Clear();
                TrialLinked.Clear();
                StringDict.Clear();
                foreach (var trials in TrialDict)
                {
                    TrialLinked.AddLast(trials.Key);
                    StringLinked.AddLast(trials.Key.ToString());
                    StringDict.Add(trials.Key.ToString(), trials.Value);
                }
            }
            catch (Exception ex)
            {
                ColorDisplay("Ошибка генерации: " + ex.Message + "\n", ConsoleColor.Red);
            }
        }
        public void Delete()
        {
            Trial key = Trial.InputTrial();
            if (TrialDict.Remove(key))
            {
                ColorDisplay($"Объект: {key}, успешно удалён!\n", ConsoleColor.Cyan);
            }
            else
            {
                ColorDisplay("Такого ключа нет в словаре!\n", ConsoleColor.Red);
            }
            StringLinked.Clear();
            TrialLinked.Clear();
            StringDict.Clear();
            foreach (var trial in TrialDict)
            {
                TrialLinked.AddLast(trial.Key);
                StringLinked.AddLast(trial.Key.ToString());
                StringDict.Add(trial.Key.ToString(), trial.Value);
            }
        }
    }
}
