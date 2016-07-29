using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCore.Interfaces
{
    public interface ISort
    {
        void Sort(IComparable[] a);
        bool IsLess(IComparable v, IComparable w);
        void Exchange(IComparable[] a, int i, int j);
        void Print(IComparable[] a);
        bool IsSorted(IComparable[] a);
    }
}
