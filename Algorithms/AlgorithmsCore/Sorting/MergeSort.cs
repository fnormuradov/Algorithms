using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCore.Sorting
{
    public class MergeTDSort : BaseMergeSort
    {
        public override void Sort(IComparable[] a)
        {
            _aux = new IComparable[a.Length]; // Allocate space just once.
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

    }

    public class MergeBUSort : BaseMergeSort
    {
        public override void Sort(IComparable[] a)
        { // Do lg N passes of pairwise merges.
            int N = a.Length;
            _aux = new IComparable[N];
            for (int sz = 1; sz < N; sz = sz + sz) // sz: subarray size
                for (int lo = 0; lo < N - sz; lo += sz + sz) // lo: subarray index
                    Merge(a, lo, lo + sz - 1, Math.Min(lo + sz + sz - 1, N - 1));
        }
    }

    public abstract class BaseMergeSort : BaseSort
    {
        public IComparable[] _aux;
        public void Merge(IComparable[] a, int lo, int mid, int hi)
        { // Merge a[lo..mid] with a[mid+1..hi].
            _aux = new IComparable[a.Length];
            int i = lo, j = mid + 1;
            for (int k = lo; k <= hi; k++) // Copy a[lo..hi] to aux[lo..hi].
                _aux[k] = a[k];
            for (int k = lo; k <= hi; k++) // Merge back to a[lo..hi].
                if (i > mid) a[k] = _aux[j++];
                else if (j > hi) a[k] = _aux[i++];
                else if (IsLess(_aux[j], _aux[i])) a[k] = _aux[j++];
                else a[k] = _aux[i++];
        }
    }
}
