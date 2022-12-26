using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CH_Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №6");
            Console.WriteLine("Работа с одномерным массивом типа int");
            bool isExit = false;
            bool isOne = false;
            bool isTwo = false;
            ArrOneLab6 first = new ArrOneLab6();
            StringClass str = new StringClass();
            int choose = 0;
            do
            {
                Console.WriteLine("\n1. Работа с массивом\n2. Работа со строкой\n3. Выход ");
                choose = 0;
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("\n1. Создать массив\n2. Вывести массив\n3. Выполнить удаление элементов кратных минимальному значению\n4. Назад ");
                            choose = 0;
                            choose = Convert.ToInt32(Console.ReadLine());
                            switch (choose)
                            {
                                case 1:
                                    do
                                    {
                                        isTwo = false;
                                        choose = 0;
                                        Console.WriteLine("\n1. Создать массив вручную\n2. Создать массив с помощью ДСЧ\n3. Назад ");
                                        choose = Convert.ToInt32(Console.ReadLine());
                                        switch (choose)
                                        {
                                            case 1:
                                                first.Creat_hands();
                                                isOne = true;
                                                break;
                                            case 2:
                                                first.Creat_DSCH();
                                                isOne = true;
                                                break;
                                            case 3:
                                                isOne = true;
                                                break;
                                            default:
                                                Console.WriteLine("\nОшибка, нужно ввести предложенное число!");
                                                break;
                                        }
                                    } while (!isOne);
                                    isOne = true;
                                    break;
                                case 2:
                                    if (first.Arr.Length == 0)
                                    {
                                        Console.WriteLine("\nМассив пуст.");
                                    }
                                    else
                                    {
                                        first.Print();
                                    }
                                    break;
                                case 3:
                                    //first.Del();
                                    break;
                                case 4:
                                    isTwo = true;
                                    break;
                                default:
                                    Console.WriteLine("\nОшибка, нужно ввести предложенное число!");
                                    break;
                            }
                        } while (!isTwo);
                        isTwo = true;
                        break;
                    case 2:
                        do
                        {
                            isTwo = false;
                            Console.WriteLine("\n1. Создать строку\n2. Вывести строку\n3. Выполнить удаление строк, которые начинаются с цифр\n4. Назад ");
                            choose = 0;
                            choose = Convert.ToInt32(Console.ReadLine());
                            switch (choose)
                            {
                                case 1:
                                    str.Create_str();
                                    break;
                                case 2:
                                    str.Print();
                                    break;
                                case 3:
                                    str.Del();
                                    break;
                                case 4:
                                    isTwo = true;
                                    break;
                                default:
                                    Console.WriteLine("\nОшибка, нужно ввести предложенное число!");
                                    break;
                            }
                        } while (!isTwo);
                        isTwo = true;
                        break;
                    case 3:
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine("\nОшибка, нужно ввести предложенное число!");
                        break;
                }
            } while (!isExit);
        }
    }
}
