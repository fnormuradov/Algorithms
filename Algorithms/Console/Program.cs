using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsCore;
using Web.Controllers;

namespace Console
{
    class Program
    {

        private static void Main()
        {
            int n = Convert.ToInt32(System.Console.ReadLine());
            string[] arr_temp = System.Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            var powersOfTwo = new List<int>();
            var potPower = 2;
            var max = 2 * Math.Pow(10, 8);
            var result = 0;

            do
            {
                powersOfTwo.Add(potPower);
                potPower *= 2;
            } while (potPower < max);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == i) break;
                    else if (powersOfTwo.Contains(arr[i] + arr[j]))
                        result++;

                }
            }
            System.Console.WriteLine(result);
           // System.Console.ReadKey();
        }
    }

}
