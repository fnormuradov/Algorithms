using System;
namespace AlgorithmsCore.Sorting
{
    public class SelectionSort : BaseSort
    {
        public override void Sort(IComparable[] a)
        {
            int N = a.Length;
            for (var i = 0; i < N - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < N; j++)
                {
                    if (IsLess(a[j], a[min]))
                        min = j;
                }
                Exchange(a, i, min);
            }
        }
    }
}
