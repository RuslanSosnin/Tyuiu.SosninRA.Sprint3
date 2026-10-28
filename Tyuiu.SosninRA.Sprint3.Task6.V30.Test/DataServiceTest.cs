using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SosninRA.Sprint3.Task6.V30.Lib;

namespace Tyuiu.SosninRA.Sprint3.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCountTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 11;
            int stopValue = 17;

            int res = ds.GetCountTheDivisors(startValue, stopValue);
            int wait = 25;

            Assert.AreEqual(wait, res);
        }
    }
}