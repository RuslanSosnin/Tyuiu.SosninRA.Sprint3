using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SosninRA.Sprint3.Task6.V30.Lib
{
    public class DataService : ISprint3Task6V30
    {
        public int GetCountTheDivisors(int startValue, int stopValue)
        {
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        // Если в интерфейсе ISprint3Task6V30 метод называется GetSumTheDivisors:
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            return GetCountTheDivisors(startValue, stopValue);
        }
    }
}