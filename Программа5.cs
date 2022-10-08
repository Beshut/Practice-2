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
            byte var1 = 250;//обьявление переменной, присвоение значения
            byte var2 = 150;//обьявление переменной, присвоение значения
            try//оператор, выполняется если не возникает ошибки в фрагменте программы
            {
                byte sum = checked((byte)(var1 + var2));//обьявление переменной, присвоение значения, выполнение арифметический операций
                Console.WriteLine("Сумма: {0}", sum);//вывод на экран сообщения
            }
            catch (OverflowException ex)//оператор, выполняется при возникновении ошибки OverflowException и присваивает переменной "ex"
            {
                Console.WriteLine(ex.Message);//вывод на экран сообщения пользователю
                Console.ReadLine();//ожидание нажатия клавиши
            }

        }
    }
}
