using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsCore;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangleNumbers = Algorithms.GenerateTriangleNumbers(100000);
            for (var i = 3000; i < 1000000; i++)
            {
                var triangleNumber = triangleNumbers[i];
                System.Console.WriteLine(triangleNumber);
                if (triangleNumber.IsEven)
                {
                    var primeFactors = Algorithms.FactorizeBruteForce(triangleNumber);

                    var numberOfFactors = Algorithms.GetNumberOfFactors(primeFactors.Item2);
                    System.Console.WriteLine(triangleNumber + " | " + numberOfFactors);
                    System.Console.ReadKey();
                    if (numberOfFactors > 500)
                    {
                        System.Console.WriteLine(triangleNumber + " | " + numberOfFactors);
                        System.Console.ReadKey();
                        break;
                    }
                }
            }
        }

    }
}
