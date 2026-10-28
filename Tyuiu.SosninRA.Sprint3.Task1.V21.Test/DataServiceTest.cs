using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SosninRA.Sprint3.Task1.V21.Lib;

namespace Tyuiu.SosninRA.Sprint3.Task1.V21.Test
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
            int stopValue = 12;

            double res = ds.GetMultiplySeries(x, startValue, stopValue);
            double wait = 16949128.283;

            Assert.AreEqual(wait, res);
        }
    }
}