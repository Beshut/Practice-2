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
            short d = 1;//обьявление переменных, присвоение значения

            for (byte i = 0; i < 10; i++)//условный оператор, выполняется пока i < 10
                Console.Write(i + d++ + "\t");//вывод на экран переменных

            Console.WriteLine();//пустая строка
            d = 1;//присваивание значения

            for (byte i = 0; i < 10; i++)//условный оператор, выполняется пока i < 10
                Console.Write(i + ++d + "\t");//вывод на экран переменных

            Console.ReadLine();//ожидание нажатия клавиши
        }

    }
}
