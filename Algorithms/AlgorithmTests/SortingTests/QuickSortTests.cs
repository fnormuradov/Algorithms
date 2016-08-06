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
    public class QuickSortTests
    {
        [TestMethod]
        public void BaseTest()
        {
            var a = new IComparable[] { 3, 5, 4, 2, 1 };
            var s = new QuickSort();
            s.Sort(a);
            Assert.IsTrue(s.IsSorted(a));
        }
        [TestMethod]
        public void WorstCaseTest()
        {
            var a = CollectionHelper.GetWorstCaseArray(10000);
            var mSort = new QuickSort();
            mSort.Sort(a);
            Assert.IsTrue(mSort.IsSorted(a));
        }
    }
}
