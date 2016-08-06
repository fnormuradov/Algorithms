using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsCore.Sorting;

namespace AlgorithmsCore.Sorting
{
    public class InsertionSort : BaseSort
    {
        public override void Sort(IComparable[] a)
        {
            for (int i = 1; i < a.Length; i++)
                for (int j = i; j > 0 && IsLess(a[j], a[j - 1]); j--)
                    Exchange(a, j, j - 1);
        }
    }
}
