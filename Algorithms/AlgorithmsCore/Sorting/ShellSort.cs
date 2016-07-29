using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCore.Sorting
{
    public class ShellSort : BaseSort
    {
        public override void Sort(IComparable[] a)
        { // Sort a[] into increasing order.
            int N = a.Length;
            int h = 1;
            while (h < N / 3)
                h = 3 * h + 1; // 1, 4, 13, 40, 121, 364, 1093, ...
            while (h >= 1)
            { // h-sort the array.
                for (int i = h; i < N; i++)
                { // Insert a[i] among a[i-h], a[i-2*h], a[i-3*h]... .
                    for (int j = i; j >= h && IsLess(a[j], a[j - h]); j -= h)
                        Exchange(a, j, j - h);
                }
                h = h / 3;
            }
        }
    }
    public class ExtendedShellSort : BaseSort
    {
        public override void Sort(IComparable[] a)
        { // Sort a[] into increasing order.
            int N = a.Length;
            List<int> H = new List<int>();
            int n = 1;
            H.Add(n);
            while (n < N / 3)
            {
                H.Add(3 * n + 1); // 1, 4, 13, 40, 121, 364, 1093, ...
                n *= 3;
            }
            H.Reverse();
            foreach (var h in H)
            { // h-sort the array.
                for (int i = h; i < N; i++)
                { // Insert a[i] among a[i-h], a[i-2*h], a[i-3*h]... .
                    for (int j = i; j >= h && IsLess(a[j], a[j - h]); j -= h)
                        Exchange(a, j, j - h);
                }

            }
        }
    }
}
