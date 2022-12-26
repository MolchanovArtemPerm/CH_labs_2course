using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CH_Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №5");
            bool isExit = false;
            bool isOne = false;
            bool isTwo = false;
            Random rnd = new Random();
            ArrOne first = new ArrOne();
            ArrTwo second = new ArrTwo();
            ArrJag third = new ArrJag();
            int choose = 0;
            do
            {
                Console.WriteLine("\n1. Работа с одномерным массивом\n2. Работа с двумерным массивом\n3. Работа с рваным массивом\n4. Выход");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        do
                        {
                            choose = 0;
                            Console.WriteLine("\n1. Создать массив\n2. Напечатать массив\n3. Удалить все четные элементы\n4. Назад ");
                            choose = Convert.ToInt32(Console.ReadLine());
                            switch (choose)
                            {
                                case 1:
                                    do
                                    {
                                        choose = 0;
                                        Console.WriteLine("\n1. Создать массив вручную\n2. Создать массив с помощью ДСЧ\n3. Назад ");
                                        choose = Convert.ToInt32(Console.ReadLine());
                                        switch (choose)
                                        {
                                            case 1:
                                                first.Creat_hands();
                                                isTwo = true;
                                                break;
                                            case 2:
                                                first.Creat_DSCH();
                                                isTwo = true;
                                                break;
                                            case 3:
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
                                    first.Del();
                                    break;
                                case 4:
                                    isOne = true;
                                    break;
                                default:
                                    Console.WriteLine("\nОшибка, нужно ввести предложенное число!");
                                    break;
                            }
                        } while (!isOne);
                        isOne = false;
                        break;
                    case 2:
                        do
                        {
                            choose = 0;
                            Console.WriteLine("\n1. Создать массив\n2. Напечатать массив\n3. Добавить К строк, начиная со строки с номером N\n4. Назад ");
                            choose = Convert.ToInt32(Console.ReadLine());
                            switch (choose)
                            {
                                case 1:
                                    do
                                    {
                                        choose = 0;
                                        Console.WriteLine("\n1. Создать массив вручную\n2. Создать массив с помощью ДСЧ\n3. Назад ");
                                        choose = Convert.ToInt32(Console.ReadLine());
                                        switch (choose)
                                        {
                                            case 1:
                                                second.Creat_hands();
                                                isTwo = true;
                                                break;
                                            case 2:
                                                second.Creat_DSCH();
                                                isTwo = true;
                                                break;
                                            case 3:
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
                                    if (second.Arr2.Length == 0)
                                    {
                                        Console.WriteLine("\nМассив пуст.");
                                    }
                                    else
                                    {
                                        second.Print();
                                    }                                    
                                    break;
                                case 3:
                                    second.Add();
                                    break;
                                case 4:
                                    isOne = true;
                                    break;
                                default:
                                    Console.WriteLine("\nОшибка, нужно ввести предложенное число!");
                                    break;
                            }
                        } while (!isOne);
                        isOne = false;
                        break;
                    case 3:
                        do
                        {
                            choose = 0;
                            Console.WriteLine("\n1. Создать массив\n2. Напечатать массив\n3. Добавить К строк в конец массива\n4. Назад ");
                            choose = Convert.ToInt32(Console.ReadLine());
                            switch (choose)
                            {
                                case 1:
                                    do
                                    {
                                        choose = 0;
                                        Console.WriteLine("\n1. Создать массив вручную\n2. Создать массив с помощью ДСЧ\n3. Назад ");
                                        choose = Convert.ToInt32(Console.ReadLine());
                                        switch (choose)
                                        {
                                            case 1:
                                                third.Creat_hands();
                                                isTwo = true;
                                                break;
                                            case 2:
                                                third.Creat_DSCH();
                                                isTwo = true;
                                                break;
                                            case 3:
                                                isTwo = true;
                                                break;
                                            default:
                                                Console.WriteLine("Ошибка, нужно ввести предложенное число!");
                                                break;
                                        }
                                    } while (!isTwo);
                                    isTwo = true;
                                    break;
                                case 2:
                                    third.Print();
                                    break;
                                case 3:
                                    third.Add();
                                    break;
                                case 4:
                                    isOne = true;
                                    break;
                                default:
                                    Console.WriteLine("Ошибка, нужно ввести предложенное число!");
                                    break;
                            }
                        } while (!isOne);
                        break;
                    case 4:
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
