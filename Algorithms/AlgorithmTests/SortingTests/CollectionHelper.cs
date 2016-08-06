using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTests.SortingTests
{
    public static class CollectionHelper
    {
        public static IComparable[] GetBestCaseArray(int n)
        {
            IComparable[] arr = new IComparable[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i;
            }
            return arr;
        }
        public static IComparable[] GetWorstCaseArray(int n)
        {
            IComparable[] arr = new IComparable[n];
            for (int i = n; i > 0; i--)
            {
                arr[n - i] = i;
            }
            return arr;
        }
        public static IComparable[] GetRandomArray(int n)
        {
            IComparable[] arr = new IComparable[n];
            var rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(Int32.MaxValue);
            }
            return arr;
        }
    }
}
