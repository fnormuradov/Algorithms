using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCore.Sorting
{
    public class QuickSort : BaseSort
    {
        private Random r = new Random();
        public override void Sort(IComparable[] a)
        {
            a.OrderBy(i => r.Next());// Eliminate dependence on input.
            Sort(a, 0, a.Length - 1);
        }
        private void Sort(IComparable[] a, int lo, int hi)
        {
            if (hi <= lo) return;
            int j = Partition(a, lo, hi); // Partition (see page 291).
            Sort(a, lo, j - 1); // Sort left part a[lo .. j-1].
            Sort(a, j + 1, hi); // Sort right part a[j+1 .. hi].
        }
        private int Partition(IComparable[] a, int lo, int hi)
        { // Partition into a[lo..i-1], a[i], a[i+1..hi].
            int i = lo, j = hi + 1; // left and right scan indices
            IComparable v = a[lo]; // partitioning item
            while (true)
            { // Scan right, scan left, check for scan complete, and exchange.
                while (IsLess(a[++i], v)) if (i == hi) break;
                while (IsLess(v, a[--j])) if (j == lo) break;
                if (i >= j) break;
                Exchange(a, i, j);
            }
            Exchange(a, lo, j); // Put v = a[j] into position
            return j; // with a[lo..j-1] <= a[j] <= a[j+1..hi].
        }
    }
}
