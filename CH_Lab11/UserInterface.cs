using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CH_Lab11.Program;

namespace CH_Lab11
{
    static class UserInterface
    {
        public static void execute()
        {
            bool Exit = false;
            LinkedList<Trial> TrialsLinked = GenerateLinkedList();
            Dictionary<Trial, Test> TrialsDict = GenerateDictionary();
            TestCollections testCollections = new TestCollections(TestCollections.MIN_LENGTH);

            while (!Exit)
            {
                Console.Clear();
                Program.ColorDisplay("Номера команд:\n1. 1 часть\n2. 2 часть\n3. 3 часть\n0. Выход\n", ConsoleColor.Blue);
                int command = Program.GetInt("Введите номер команды: ", "Несуществующая команда, повторите ввод\n", (int num) => num >= 0 && num <= 3);
                Console.Clear();
                switch (command)
                {
                    case 1:
                        task1(ref TrialsLinked);
                        break;
                    case 2:
                        task2(ref TrialsDict);
                        break;
                    case 3:
                        task3(ref testCollections);
                        break;
                    case 0:
                        Exit = true;
                        break;
                }
            }
        }
        public static void task1(ref LinkedList<Trial> TrialsLinked)
        {
            bool Exit = false;
            while (!Exit)
            {
                Program.ColorDisplay("Номера команд:\n" +
                   "1. Генерация и вывод нового списка\n" +
                   "2. Добавить объект в список (объект добавиться в конец)\n" +
                   "3. Удалить объект из списка (удалится первый объект)\n" +
                   "4. Вывести все элементы типа Trial и их количество\n" +
                   "5. Вывести все элементы типа Test и их количество\n" +
                   "6. Вывести все элементы типа Exam и их количество\n" +
                   "7. Вывести все элементы типа ExamOut и их количество\n" +
                   "8. Выполнить клонирование коллекции\n" +
                   "9. Выполнить сортировку коллекции\n" +
                   "10. Выполнить поиск элемента в коллекции\n" +
                   "0. Назад\n", ConsoleColor.Blue);
                ColorDisplay("Исходная список:\n", ConsoleColor.Magenta);
                DisplayLinkedList(TrialsLinked);
                int command = Program.GetInt("Введите номер команды: ", "Несуществующая команда, повторите ввод\n", (int num) => num >= 0 && num <= 10);
                switch (command)
                {
                    case 1:
                        TrialsLinked = GenerateLinkedList();
                        DisplayLinkedList(TrialsLinked);
                        break;
                    case 2:
                        TrialsLinked.AddLast(Trial.InputTrial());
                        break;
                    case 3:
                        if (TrialsLinked.Count != 0)
                        {
                            ColorDisplay($"Из начала списка удалён объект: {TrialsLinked.First()}!\n", ConsoleColor.Cyan);
                            TrialsLinked.RemoveFirst();
                        }
                        else
                            ColorDisplay("Удаление из пустого списка невозможно!\n", ConsoleColor.Red);
                        break;
                    case 4:
                        DisplayTypeInLinkedList(TrialsLinked, typeof(Trial));
                        break;
                    case 5:
                        DisplayTypeInLinkedList(TrialsLinked, typeof(Test));
                        break;
                    case 6:
                        DisplayTypeInLinkedList(TrialsLinked, typeof(Exam));
                        break;
                    case 7:
                        DisplayTypeInLinkedList(TrialsLinked, typeof(ExamOut));
                        break;
                    case 8:
                        LinkedList<Trial> personsQueueCopy = CopyLinkedList(TrialsLinked);
                        int len = TrialsLinked.Count;
                        for (int i = 0; i < len; ++i)
                        {
                            ColorDisplay($"Из начала исходного списка удалён объект: {TrialsLinked.First()}!\n", ConsoleColor.Cyan);
                            TrialsLinked.RemoveFirst();
                        }
                        ColorDisplay("Исходный список:\n", ConsoleColor.Magenta);
                        DisplayLinkedList(TrialsLinked);
                        ColorDisplay("Копия списка:\n", ConsoleColor.Magenta);
                        DisplayLinkedList(personsQueueCopy);
                        TrialsLinked = CopyLinkedList(personsQueueCopy);
                        break;
                    case 9:
                        SortLinkedList(ref TrialsLinked);
                        ColorDisplay("Список успешно отсортирована!\n", ConsoleColor.Blue);
                        break;
                    case 10:
                        Console.WriteLine($"Индекс элемента в списке: {FindPerson(TrialsLinked, Trial.InputTrial())}");
                        break;
                    case 0:
                        Exit = true;
                        break;
                }
                Program.ColorDisplay("Для продолжения нажмите любую клавишу...", ConsoleColor.Yellow);
                Console.ReadKey();
                Console.Clear();
            }

        }
        public static void task2(ref Dictionary<Trial, Test> TrialsDict)
        {
            bool Exit = false;
            while (!Exit)
            {
                Program.ColorDisplay("Номера команд:\n" +
                   "1. Генерация и вывод нового словаря\n" +
                   "2. Добавить объект в словарь\n" +
                   "3. Удалить объект из словаря\n" +
                   "4. Вывести все элементы типа Test и их количество\n" +
                   "5. Вывести все элементы типа Exam и их " +
                   "количество\n" +
                   "6. Вывести все элементы типа ExamOut и их количество\n" +
                   "7. Выполнить клонирование коллекции\n" +
                   "8. Выполнить поиск элемента в коллекции\n" +
                   "0. Назад\n", ConsoleColor.Blue);
                ColorDisplay("Исходный словарь:\n", ConsoleColor.Magenta);
                DisplayDictionary(TrialsDict);
                int command = Program.GetInt("Введите номер команды: ", "Несуществующая команда, повторите ввод\n", (int num) => num >= 0 && num <= 8);
                switch (command)
                {
                    case 1:
                        TrialsDict = GenerateDictionary();
                        break;
                    case 2:
                        InsertRandomIntoDictionary(ref TrialsDict);
                        break;
                    case 3:
                        DeletePersonFromDictionary(ref TrialsDict);
                        break;
                    case 4:
                        DisplayTypeInDictionary(TrialsDict, typeof(Test));
                        break;
                    case 5:
                        DisplayTypeInDictionary(TrialsDict, typeof(Exam));
                        break;
                    case 6:
                        DisplayTypeInDictionary(TrialsDict, typeof(ExamOut));
                        break;
                    case 7:
                        var personsDictCopy = CopyDictionary(TrialsDict);
                        TrialsDict.Clear();
                        ColorDisplay("Исходный словарь:\n", ConsoleColor.Magenta);
                        DisplayDictionary(TrialsDict);
                        ColorDisplay("Копия словаря:\n", ConsoleColor.Magenta);
                        DisplayDictionary(personsDictCopy);
                        TrialsDict = CopyDictionary(personsDictCopy);
                        break;
                    case 8:
                        try
                        {
                            ColorDisplay($"Объект {TrialsDict[Trial.InputTrial()]} содержтися в словаре!\n", ConsoleColor.Cyan);
                        }
                        catch (Exception ex)
                        {
                            ColorDisplay($"{ex.Message}\n", ConsoleColor.Red);
                        }
                        break;
                    case 0:
                        Exit = true;
                        break;
                }
                Program.ColorDisplay("Для продолжения нажмите любую клавишу...", ConsoleColor.Yellow);
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void task3(ref TestCollections testCollections)
        {
            bool Exit = false;
            while (!Exit)
            {
                Program.ColorDisplay("Номера команд:\n" +
                   "1. Генерация и вывод нового объекта TestCollections\n" +
                   "2. Добавить элемент в TestCollections\n" +
                   "3. Удалить объект из TestCollections\n" +
                   "4. Запустить тесты\n" +
                   "0. Назад\n", ConsoleColor.Blue);
                ColorDisplay("Исходный объект TestCollections:\n", ConsoleColor.Magenta);
                testCollections.Display();
                int command = Program.GetInt("Введите номер команды: ", "Несуществующая команда, повторите ввод\n", (int num) => num >= 0 && num <= 4);
                switch (command)
                {
                    case 1:
                        testCollections = new TestCollections(Program.GetInt("Введите длину коллекций для тестирования: ",
                $"Длина должна быть целым цислом в диапозоне [{TestCollections.MIN_LENGTH}, {TestCollections.MAX_LENGTH - 1}, повторите ввод\n",
                (int num) => num >= TestCollections.MIN_LENGTH && num <= TestCollections.MAX_LENGTH - 1));
                        break;
                    case 2:
                        testCollections.AddRandom();
                        break;
                    case 3:
                        testCollections.Delete();
                        break;
                    case 4:
                        testCollections.RunTests();
                        break;
                    case 0:
                        Exit = true;
                        break;
                }
                Program.ColorDisplay("Для продолжения нажмите любую клавишу...", ConsoleColor.Yellow);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
