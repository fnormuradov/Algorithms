using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCore
{
    public static partial class Algorithms
    {
        /// <summary>
        /// Generate list of triangle numbers up to the nth element inclusively
        /// </summary>
        /// <param name="n">Number of elements to generate</param>
        /// <returns></returns>
        public static List<BigInteger> GenerateTriangleNumbers(BigInteger n)
        {
            // Explanation
            // Triangle(or triangular) number is an amount of objects that can form equilateral triangle
            // The nth triangle number is the number of dots composing a triangle with n dots on a side

            //                                       *
            //                           *          * *
            //               *          * *        * * *
            //    *         * *        * * *      * * * *
            // T1 = 1     T2 = 3      T3 = 6      T4 = 10

            // In this case n = 4, and the resulting triangle numbers = {1, 3, 6, 10}
            // Read more: https://www.mathsisfun.com/algebra/triangular-numbers.html

            // The task is to generate list of triangle numbers up to the nth element inclusively.
            // To do so, you will need to find every triangle number up to the nth element and add them to a list.
            // If you find another way to solve the problem, feel free to share.

            // Instructions
            // Step 1. While the number of found triangle numbers is less than or equals to n, 
            //         find a triangle number using formula from the link above
            // Step 2. Add it to the list of found triangle numbers
            // Step 3. Repeat the process to find the next triangle number

            // Enhance the code below or replace it entirely with your implementation
            var triangleNumbers = new List<BigInteger>();
            return triangleNumbers;
        }
    }
}
