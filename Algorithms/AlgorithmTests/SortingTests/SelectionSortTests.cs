using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsCore.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests.SortingTests
{
    [TestClass]
    public class SelectionSortTests
    {
        [TestMethod]
        public void MainTest()
        {
            var a = new IComparable[] { 10, 8, 6 };
            var sorted = new IComparable[] { 6, 8, 10 };
            var mSort = new SelectionSort();
            mSort.Sort(a);
            CollectionAssert.AreEqual(sorted, a);
        }

        [TestMethod]
        public void WorstCaseTest()
        {
            var a = CollectionHelper.GetWorstCaseArray(10000);
            var mSort = new SelectionSort();
            mSort.Sort(a);
            Assert.IsTrue(mSort.IsSorted(a));
        }
        [TestMethod]
        public void WorstCaseComparison()
        {
            var stopWatch = new Stopwatch();
            var a1 = CollectionHelper.GetWorstCaseArray(20000);
            var a2 = (IComparable[])a1.Clone();
            var sSort = new SelectionSort();
            var jSort = new JahongirSort();

            stopWatch.Start();
            sSort.Sort(a1);
            stopWatch.Stop();
            var sTime = stopWatch.ElapsedMilliseconds;

            stopWatch.Reset();

            stopWatch.Start();
            jSort.Sort(a2);
            stopWatch.Stop();
            var jTime = stopWatch.ElapsedMilliseconds;

            Console.WriteLine($"# 20000: Jahongir time {jTime}, SelectionSort time {sTime}");
            // Console.WriteLine($"Maskim's algo is {mTime / jTime} times faster");
        }
    }
}
