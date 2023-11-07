using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IlyinME.Sprint4.Task4.V2.Lib;

namespace Tyuiu.IlyinME.Sprint4.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 2, 2, 5, 5, 9 },
                                            { 7, 3, 8, 8, 9 },
                                            { 6, 7, 9, 3, 5 },
                                            { 7, 5, 7, 7, 8 },
                                            { 2, 2, 4, 7, 9 } };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = new int[5, 5] { { 2, 2, 0, 0, 0 },
                                          { 0, 0, 8, 8, 0 },
                                          { 6, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 8 },
                                          { 2, 2, 4, 0, 0 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
