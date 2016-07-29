using System;
using AlgorithmsCore.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests.Sorting
{
    [TestClass]
    public class BaseSortTests
    {
        [TestMethod]
        public void IsLess()
        {
            var a = new IComparable[] { 3, 5, 7 };
            var sorter = new InsertionSort();
            Assert.IsTrue(sorter.IsLess(a[0], a[1]));
        }
        [TestMethod]
        public void MinTest()
        {
            var a = new IComparable[] { 4, 5, 7, 8, 6, 8, 5, 3, 5, 7 };
            var sorter = new InsertionSort();
            Assert.AreEqual(3, a[sorter.Min(a, 0, a.Length - 1)]);
        }
    }
}
