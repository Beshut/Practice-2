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
            // *** Расчет стоимости капиталовложения с ***
            // *** фиксированной нормой прибыли***
            decimal money, percent;//обьявление переменных
            int i;//обьявление переменной
            const byte years = 15;//обьявление переменной в виде константы, присвоение значения

            money = 1000.0m;//присвоение значения
            percent = 0.045m;//присвоение значения

            for (i = 1; i <= years; i++)//условный оператор, выполняется пока i <= years
            {
                money *= 1 + percent;//присвоение значения, выполнение арифметических операций
            }

            Console.WriteLine("Общий доход за {0} лет: {1} $$", years, money);//вывод на экран сообщения пользователю
            Console.ReadLine();//ожидание нажатия клавиши
        }
    }
}
