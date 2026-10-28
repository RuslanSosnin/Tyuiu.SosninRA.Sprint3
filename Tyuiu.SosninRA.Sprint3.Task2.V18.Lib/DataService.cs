using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SosninRA.Sprint3.Task2.V18.Lib
{
    public class DataService : ISprint3Task2V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multSeries = 1;

            do
            {
                multSeries *= Math.Cos(value) + Math.Pow(startValue / 8.0, 3);
                startValue++;
            } while (startValue <= stopValue);

            return Math.Round(multSeries, 3);
        }
    }
}
