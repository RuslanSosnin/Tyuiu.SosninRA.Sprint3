using System;
using Tyuiu.SosninRA.Sprint3.Task5.V18.Lib;

namespace Tyuiu.SosninRA.Sprint3.Task5.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Соснин Р. А.                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, используя вложенные циклы, которая вычисляет        *");
            Console.WriteLine("* сумму ряда по формуле при x = 5.                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 11;

            Console.WriteLine("Переменная X = " + x);
            Console.WriteLine("Старт шага первой суммы = " + startValue1);
            Console.WriteLine("Конец шага первой суммы = " + stopValue1);
            Console.WriteLine("Старт шага второй суммы = " + startValue2);
            Console.WriteLine("Конец шага второй суммы = " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

            Console.ReadLine();
        }
    }
}