using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IlyinME.Sprint4.Task6.V14.Lib;

namespace Tyuiu.IlyinME.Sprint4.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };
            string[] res = ds.Calculate(months);
            string[] wait = { "Январь", "Февраль", "Март", "Апрель", "Июнь", "Июль" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
