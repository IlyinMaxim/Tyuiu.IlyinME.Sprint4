using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IlyinME.Sprint4.Task2.V1.Lib;

namespace Tyuiu.IlyinME.Sprint4.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValueCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            int res = ds.Calculate(numsArray);
            int wait = 256;
            Assert.AreEqual(wait, res);
        }
    }
}
