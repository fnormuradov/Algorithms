using System;
namespace AlgorithmsCore.Sorting
{
    public class InsertionSort : BaseSort
    {
        public override void Sort(IComparable[] a)
        {
            int N = a.Length;
            for (int i = 1; i < N; i++)
            {
                for (int j = i; j > 0 && IsLess(a[j], a[j - 1]); j--)
                {
                    Exchange(a, j, j - 1);
                }
            }
        }
    }
    public class InsertionSortWithoutExchanges : BaseSort
    {
        public override void Sort(IComparable[] a)
        {
            int N = a.Length;
            for (int i = 1; i < N; i++)
            {
                
            }
        }
    }
}
