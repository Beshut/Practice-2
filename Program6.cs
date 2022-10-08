using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;//обьявление переменных
            float f1, f2;//обьявление переменных

            num1 = 13 / 3;//присвоение значения
            num2 = 13 % 3;//присвоение значения

            f1 = 13.0f / 3.0f;//присвоение значения
            f2 = 13.0f % 3.0f;//присвоение значения

            Console.WriteLine("Результат и остаток от деления 13 на 3: {0} __ {1}", num1, num2);//вывод на экран сообщения пользователю
            Console.WriteLine("Результат деления 13.0 на 3.0: {0:#.###} {1}", f1, f2);//вывод на экран сообщения пользователю

            Console.ReadLine();//ожидание нажатия клавиши
        }
    }
}
