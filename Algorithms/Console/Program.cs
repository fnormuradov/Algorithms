using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsCore;
using AlgorithmsCore.Sorting;
using AlgorithmTests.SortingTests;
using Web.Controllers;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var jSort = new JahongirSort();
            var sSort = new SelectionSort();
            var iSort = new InsertionSort();
            var mSort = new MergeSort();
            var shellSort = new ShellSort();
            var qSort = new QuickSort();
            var sorts = new BaseSort[] { qSort, mSort };
            for (int i = 10; i < 100000000; i *= 10)
            {
                System.Console.WriteLine("Number of elements: " + i);
                foreach (var s in sorts)

                    SortTestRunner(s, i);

                System.Console.ReadKey();
                System.Console.WriteLine("==============");
            }
        }

        private static void SortTestRunner(BaseSort sort, int n)
        {
            var stopWatch = new Stopwatch();
            var bestCase = CollectionHelper.GetBestCaseArray(n);
            var worstCase = CollectionHelper.GetWorstCaseArray(n);
            var randomCase = CollectionHelper.GetRandomArray(n);
            stopWatch.Start();
            sort.Sort(bestCase);
            stopWatch.Stop();
            var bestCaseTime = stopWatch.ElapsedMilliseconds;
            stopWatch.Reset();
            stopWatch.Start();
            sort.Sort(worstCase);
            stopWatch.Stop();
            var worstCaseTime = stopWatch.ElapsedMilliseconds;
            stopWatch.Reset();
            stopWatch.Start();
            sort.Sort(randomCase);
            stopWatch.Stop();
            var randomCaseTime = stopWatch.ElapsedMilliseconds;
            System.Console.WriteLine("Best: {0} | Worst: {1} | Random: {2} | {3}",
                bestCaseTime, worstCaseTime, randomCaseTime, sort.GetType().Name);
        }

    }
}
