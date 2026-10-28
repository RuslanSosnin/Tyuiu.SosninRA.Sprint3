using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SosninRA.Sprint3.Task7.V14.Lib;

namespace Tyuiu.SosninRA.Sprint3.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] wait = new double[11]
            {
                -19.62,
                -17.12,
                -18.15,
                -63.13,
                -24.92,
                -5.00,
                -1.46,
                1.57,
                6.38,
                32.78,
                225.11
            };

            double[] res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
