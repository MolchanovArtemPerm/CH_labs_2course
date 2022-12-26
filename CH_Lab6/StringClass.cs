using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CH_Lab6
{
    internal class StringClass
    {
        string str,strTemp;
        bool isFlag = false;
        char[] charArray = {'1','2','3','4','5','6','7','8','9','0'};
        public void Create_str()
        {
            Console.Write("\nВведите строку: ");
            str = Console.ReadLine();
        }
        public void Del()
        {
            if (str == null)
            {
                Console.WriteLine("\nСтрока пустая!");
            }
            else
            {
                for(int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ')
                    {
                        strTemp += " ";
                        isFlag = false;
                        for (int j = 0; j < charArray.Length; j++)
                        {
                            if (str[i + 1] == charArray[j])
                            {
                                isFlag = true;
                            }
                        }
                    }
                    if (!isFlag)
                    {
                        strTemp += str[i];
                    }
                }
            }
            str = strTemp;
            while (str.Contains("  "))
            {
                str = str.Replace("  ", " ");
            }
        }
        public void Print()
        {
            if(str == null)
            {
                Console.WriteLine("\nСтрока пустая!");
            }
            else
            {
                Console.WriteLine("\nСтрока: {0}",str);
            }
        }
    }
}
