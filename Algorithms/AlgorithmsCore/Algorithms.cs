using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCore
{
    public static partial class Algorithms
    {
        public static int[] GetPrimeNumbers(int n)
        {
            var list = new List<int>();
            list.AddRange(new List<int>() { 2, 3, 5, 7, 11 });
            var possiblePrime = list.Last();
            var i = 0;
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            do
            {
                possiblePrime += 2;
                bool isDivisible = false;
                foreach (var prime in list)
                {
                    //Console.WriteLine("prime: " + prime);
                    //Console.WriteLine("possible prime: " + possiblePrime);
                    if (possiblePrime % prime == 0)
                    {
                        isDivisible = true;
                        break;
                    }
                }
                if (isDivisible == false)
                {
                    list.Add(possiblePrime);
                    i++;
                }

            } while (i < n - 1);
            Console.WriteLine("Number of primes found: " + list.Count());

            stopwatch.Stop();
            var milliSeocnds = stopwatch.ElapsedMilliseconds;

            Console.WriteLine(possiblePrime + " | " + milliSeocnds + " milliseconds.");

            System.Console.ReadKey();
            return list.ToArray();
        }

    }
}
