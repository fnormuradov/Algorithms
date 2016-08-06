using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCore.Sorting
{
    public class MergeSort : BaseSort
    {
        private IComparable[] aux; // auxiliary array for merges
        public override void Sort(IComparable[] a)
        {
            aux = new IComparable[a.Length]; // Allocate space just once.
            Sort(a, 0, a.Length - 1);
        }
        private void Sort(IComparable[] a, int lo, int hi)
        { // Sort a[lo..hi].
            if (hi <= lo) return;
            int mid = lo + (hi - lo) / 2;
            Sort(a, lo, mid); // Sort left half.
            Sort(a, mid + 1, hi); // Sort right half.
            Merge(a, lo, mid, hi); // Merge results (code on page 271).
        }

        public void Merge(IComparable[] a, int lo, int mid, int hi)
        {
            // Merge a[lo..mid] with a[mid+1..hi].
            int i = lo, j = mid + 1;
            for (int k = lo; k <= hi; k++) // Copy a[lo..hi] to aux[lo..hi].
                aux[k] = a[k];
            for (int k = lo; k <= hi; k++) // Merge back to a[lo..hi].
                if (i > mid) a[k] = aux[j++];
                else if (j > hi) a[k] = aux[i++];
                else if (IsLess(aux[j], aux[i])) a[k] = aux[j++];
                else a[k] = aux[i++];
        }
    }

}
