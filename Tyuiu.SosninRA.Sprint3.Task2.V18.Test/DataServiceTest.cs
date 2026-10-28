using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SosninRA.Sprint3.Task2.V18.Lib;

namespace Tyuiu.SosninRA.Sprint3.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int x = 1;
            int startValue = 1;
            int stopValue = 14;

            double res = ds.GetMultiplySeries(x, startValue, stopValue);
            double wait = 287.096;

            Assert.AreEqual(wait, res);
        }
    }
}
