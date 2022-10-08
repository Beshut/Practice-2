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
            byte n = 6, result;//обьявление переменных, присвоение значения

            // Умножить на 2
            result = (byte)(n << 1);//присвоение значения
            Console.WriteLine("{0} * 2 = {1}", n, result);//вывод на экран сообщения пользователю

            // Умножить на 4
            result = (byte)(n << 2);//присвоение значения
            Console.WriteLine("{0} * 4 = {1}", n, result);//вывод на экран сообщения пользователю

            // Разделить на 2
            result = (byte)(n >> 1);//присвоение значения
            Console.WriteLine("{0} / 2 = {1}", n, result);//вывод на экран сообщения пользователю

            Console.ReadLine();//ожидание нажатия клавиши
        }
    }
}
