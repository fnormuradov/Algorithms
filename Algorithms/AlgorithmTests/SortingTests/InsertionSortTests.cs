using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsCore.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests.SortingTests
{
    [TestClass]
    public class InsertionSortTests
    {
        [TestMethod]
        public void MainTest()
        {
            var a = new IComparable[] { 10, 8, 6 };
            var sorted = new IComparable[] { 6, 8, 10 };
            var mSort = new InsertionSort();
            mSort.Sort(a);
            CollectionAssert.AreEqual(sorted, a);
        }

        [TestMethod]
        public void WorstCaseTest()
        {
            var a = CollectionHelper.GetWorstCaseArray(10000);
            var mSort = new InsertionSort();
            mSort.Sort(a);
            Assert.IsTrue(mSort.IsSorted(a));
        }
    }
}
