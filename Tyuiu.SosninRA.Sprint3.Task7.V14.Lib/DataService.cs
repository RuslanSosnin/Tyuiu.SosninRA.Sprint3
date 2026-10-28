using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SosninRA.Sprint3.Task7.V14.Lib
{
    public class DataService : ISprint3Task7V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Sin(x) + 1;

                if (Math.Abs(denominator) < 0.0001)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double y = (2 * x) - 4 + ((2 * x - 1) / denominator);
                    valueArray[count] = Math.Round(y, 2);
                }

                count++;
            }

            return valueArray;
        }
    }
}
