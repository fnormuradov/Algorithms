using System;
using System.Diagnostics;
using System.Text;
using AlgorithmsCore;
using AlgorithmsCore.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests.Sorting
{
    [TestClass]
    public class SortingTests
    {
        [TestMethod]
        public void SelectionSortNumbers()
        {
            var collection = new IComparable[] { 11, 4, 7, 2, 2, 10 };
            var sorter = new SelectionSort();
            sorter.Sort(collection);
            Assert.IsTrue(sorter.IsSorted(collection));
        }
        [TestMethod]
        public void SelectionSortTiming()
        {
            var collection = GenerateNumberCollection(10000, 5);
            var sorter = new SelectionSort();
            sorter.Sort(collection);
            var result = sorter.IsSorted(collection);
            sorter.Print(collection);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void SelectionSortLetters()
        {
            var collection = new IComparable[10] { 'N', 'O', 'R', 'M', 'U', 'R', 'A', 'D', 'O', 'V' };
            var sorter = new SelectionSort();
            sorter.Sort(collection);
            var result = sorter.IsSorted(collection);
            sorter.Print(collection);
            Assert.IsTrue(result);
        }
        private IComparable[] GenerateNumberCollection(int length, int digits)
        {
            IComparable[] collection = new IComparable[length];
            for (int i = 0; i < length; i++)
            {
                collection[i] = (double)Algorithms.GenerateRandomWithString(digits);
            }
            return collection;
        }
        private IComparable[] GenerateLetterCollection(int collectionLength, int strLength)
        {
            var rand = new Random();
            IComparable[] collection = new IComparable[collectionLength];
            for (int i = 0; i < collectionLength; i++)
            {
                var letters = StringHelpers.LETTERS;
                var itemToAdd = new StringBuilder();
                for (int j = 0; j < strLength; j++)
                {
                    var randIndex = rand.Next(letters.Length - 1);
                    itemToAdd.Append(letters[randIndex]);
                }
                collection[i] = itemToAdd.ToString();
            }
            return collection;
        }
        [TestMethod]
        public void InsertionSortNumbers()
        {
            var collection = new IComparable[] { 11, 4, 7, 2, 2, 10 };
            var sorter = new InsertionSort();
            sorter.Sort(collection);
            Assert.IsTrue(sorter.IsSorted(collection));
        }
        [TestMethod]
        public void InsertionSortWithoutExchangesNumbers()
        {
            var collection = new IComparable[] { 11, 4, 7, 2, 2, 10 };
            var sorter = new InsertionSortWithoutExchanges();
            sorter.Sort(collection);
            sorter.Print(collection);
            Assert.IsTrue(sorter.IsSorted(collection));

        }
        [TestMethod]
        public void ShellSortNumbers()
        {
            var collection = GenerateNumberCollection(1000000, 7);
            var sorter = new ExtendedShellSort();
            sorter.Sort(collection);
            sorter.Print(collection);
            Assert.IsTrue(sorter.IsSorted(collection));
        }
        [TestMethod]
        public void ShellSortStrings()
        {
            var collection = GenerateLetterCollection(1000000, 7);
            var sorter = new ExtendedShellSort();
            sorter.Sort(collection);
            sorter.Print(collection);
            Assert.IsTrue(sorter.IsSorted(collection));
        }
        [TestMethod]
        public void CompareAllSorting()
        {
            var stopWatch = new Stopwatch();
            for (var j = 0; j <= 10; j++)
            {
                var i = 10000;
                var collection = GenerateNumberCollection(i, 2);
                var collectionCopy1 = (IComparable[])collection.Clone();
                var collectionCopy2 = (IComparable[])collection.Clone();
                var collectionCopy3 = (IComparable[])collection.Clone();

                var insSort = new InsertionSort();
                stopWatch.Start();
                insSort.Sort(collectionCopy1);
                //insSort.Print(collectionCopy1);
                stopWatch.Stop();
                Console.WriteLine($"{i} |The Insertion Sort time is {stopWatch.ElapsedMilliseconds}");
                var selSort = new SelectionSort();
                stopWatch.Restart();
                selSort.Sort(collection);
                //selSort.Print(collection);
                stopWatch.Stop();
                Console.WriteLine($"{i} | The Selection Sort time is {stopWatch.ElapsedMilliseconds}");
                stopWatch.Reset();
                stopWatch.Restart();
                var shellSort = new ShellSort();
                shellSort.Sort(collectionCopy2);
                stopWatch.Stop();
                Console.WriteLine($"{i} | The Shell Sort time is {stopWatch.ElapsedMilliseconds}");
                stopWatch.Reset();
                stopWatch.Restart();
                var mergeSort = new MergeTDSort();
                mergeSort.Sort(collectionCopy3);
                stopWatch.Stop();
                Console.WriteLine($"{i} | The Merge Sort time is {stopWatch.ElapsedMilliseconds}");
                stopWatch.Reset();
            }
        }

        [TestMethod]
        public void CompareShellAndMergeSorting()
        {
            var stopWatch = new Stopwatch();
            for (var j = 1000; j <= 10000; j *= 10)
            {
                var collection = GenerateNumberCollection(j, 2);
                var collectionCopy3 = (IComparable[])collection.Clone();
                stopWatch.Start();
                var shellSort = new ShellSort();
                shellSort.Sort(collection);
                stopWatch.Stop();
                Console.WriteLine($"{j} | The Shell Sort time is {stopWatch.ElapsedMilliseconds}");
                stopWatch.Reset();
                stopWatch.Restart();
                var mergeSort = new MergeTDSort();
                mergeSort.Sort(collectionCopy3);
                stopWatch.Stop();
                Console.WriteLine($"{j} | The Merge Sort time is {stopWatch.ElapsedMilliseconds}");
                stopWatch.Reset();
            }
        }
        [TestMethod]
        public void CompareTwoMergeSorting()
        {
            var stopWatch = new Stopwatch();
            for (var j = 1000; j <= 100000; j *= 10)
            {
                var collection = GenerateNumberCollection(j, 2);
                var collectionCopy3 = (IComparable[])collection.Clone();
                stopWatch.Start();
                var bottomUpSort = new MergeBUSort();
                bottomUpSort.Sort(collection);
                stopWatch.Stop();
                Console.WriteLine($"{j} | The Bottom Up Sort time is {stopWatch.ElapsedMilliseconds}");
                stopWatch.Reset();
                stopWatch.Restart();
                var topDownSort = new MergeTDSort();
                topDownSort.Sort(collectionCopy3);
                stopWatch.Stop();
                Console.WriteLine($"{j} | The Top Down Sort time is {stopWatch.ElapsedMilliseconds}");
                stopWatch.Reset();
            }
        }
        [TestMethod]
        public void QuickSortStrings()
        {
            var collection = GenerateLetterCollection(10000000, 7);
            var sorter = new QuickSort();
            sorter.Sort(collection);
            sorter.Print(collection);
            Assert.IsTrue(sorter.IsSorted(collection));
        }
        [TestMethod]
        public void CompareQuickAndShellSorting()
        {
            var stopWatch = new Stopwatch();
            for (var j = 1000; j <= 10000000; j *= 10)
            {
                var collection = GenerateNumberCollection(j, 2);
                var collectionCopy3 = (IComparable[])collection.Clone();
                stopWatch.Start();
                var quick = new QuickSort();
                quick.Sort(collection);
                stopWatch.Stop();
                Console.WriteLine($"{j} | The Quick Sort time is {stopWatch.ElapsedMilliseconds}");
                stopWatch.Reset();
                stopWatch.Restart();
                var shell = new ShellSort();
                shell.Sort(collectionCopy3);
                stopWatch.Stop();
                Console.WriteLine($"{j} | The Shell Sort time is {stopWatch.ElapsedMilliseconds}");
                stopWatch.Reset();
            }
        }
    }
}
