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
            int i1 = 455, i2 = 84500;//обьявление переменных, присвоение значения
            decimal dec = 7.98845m;//обьявление переменной, присвоение значения

            // Приводим два числа типа int
            // к типу short
            Console.WriteLine((short)i1);//вывод на экран переменной
            Console.WriteLine((short)i2);//вывод на экран переменной

            // Приводим число типа decimal
            // к типу int
            Console.WriteLine((int)dec);//вывод на экран переменной

            Console.ReadLine();//ожидание нажатия клавиши
        }
    }
}
