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
            long result;//обьявление переменной
            const long km = 149800000;// расстояние в км.

            result = km * 1000 * 100;//присвоение значения переменной после математических операций
            Console.WriteLine(result);//вывод на экран переменной
            Console.ReadLine();//ожидание нажатия клавиши
        }
    }
}
