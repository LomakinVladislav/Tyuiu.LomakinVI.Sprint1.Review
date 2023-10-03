using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint1.TaskReview.V11.Lib;

namespace Tyuiu.LomakinVI.Sprint1.TaskReview.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 2;
            int y = 3;
            double waited = 1.591;
            Assert.AreEqual(waited, ds.Calculate(x, y));
        }
    }
}
