using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCore.Sorting
{
    public class SelectionSort : BaseSort
    {
        public override void Sort(IComparable[] a)
        {
            for (int k = 0; k < a.Length; k++)
            {
                int min = Min(a, k);
                if (min != k) Exchange(a, k, min);
            }
        }

        private int Min(IComparable[] a, int lo)
        {
            int min = lo;
            for (int i = lo + 1; i < a.Length; i++)
                if (IsLess(a[i], a[min])) min = i;
            return min;
        }
    }
}
