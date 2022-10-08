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
            short num1, num2;//обьявление переменных
            num1 = 10;//присвоение значения перемнной
            num2 = 15;//присвоение значения перемнной

            Console.WriteLine("{0} + {1} = {2}", num1, num2, Sum(num1, num2));//вывод на экран сообщения пользователю
            Console.ReadLine();//ожидание нажатия клавиши
        }

        static int Sum(int x, int y)//создание собственной функции
        {
            return x + y;//процесс выполнения функции
        }
    }
}
