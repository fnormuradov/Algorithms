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
        {
            var N = a.Length;
            var k = 1;
            while (k < N) k = 3 * k + 1;
            while (k >= 1)
            {
                for (int i = k; i < N; i += k)
                    for (int j = i; j > 0; j--)
                        if (IsLess(a[j], a[j - 1]))
                            Exchange(a, j, j - 1);
                k /= 3;
            }
        }
    }
}
