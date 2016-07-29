using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsCore.Interfaces;

namespace AlgorithmsCore.Sorting
{
    public abstract class BaseSort : ISort
    {
        public abstract void Sort(IComparable[] a);

        public bool IsLess(IComparable v, IComparable w)
        {
            return v.CompareTo(w) < 0;
        }

        public void Exchange(IComparable[] a, int i, int j)
        {
            var temp1 = a[i];
            var temp2 = a[j];
            a[i] = temp2;
            a[j] = temp1;
        }

        public void Print(IComparable[] a)
        {
            var str = new StringBuilder();
            str.Append("[");
            var last = a.Last();
            foreach (var element in a)
            {
                str.Append(element);
                if (!Equals(element, last))
                    str.Append(",");
            }
            str.Append("]");
            Console.WriteLine(str);
        }

        public bool IsSorted(IComparable[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                if (IsLess(a[i], a[i - 1]))
                    return false;
            }
            return true;
        }

        public int Min(IComparable[] a, int begin, int fin)
        {
            var min = begin;
            for (int i = begin + 1; i <= fin; i++)
            {
                if (IsLess(a[i], a[min]))
                    min = i;
            }
            return min;
        }
    }
}
