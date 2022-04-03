using System.Collections.Generic;
using System;

namespace Перебор_строк
{
    class Program
    {
        static void Main(string[] args)
        {
            string specifiedString = "(()(()))";
            int length = specifiedString.Length;

            if (length == 0)
            {
                Console.WriteLine("Ошибка пустая строка");
                return;
            }

            int two = 2;

            if (length%two != 0)
            {
                Console.WriteLine("Ошибка не четное колличество скобок");
                return;
            }

            if(specifiedString[0]!='('|specifiedString[length-1]!=')')
            {
                Console.WriteLine("Ошибка не верное открытие или закрытие строки");
                return;
            }

            int bracket = 0;
            int count = 0;
            int close = 0;

            for (int i = 0; i < length; i++)
            {
                if (specifiedString[i] == '(')
                { bracket++; }
                else if (specifiedString[i] == ')')
                {
                    count++;
                    bracket--;
                }
                if (bracket == 0)
                {
                    close++;
                    count -=close;
                }
            }
            if (bracket == 0)
                Console.Write("Вложений = " + count);
            else Console.WriteLine("Ошибка не верная строка");
        }
    }
}
