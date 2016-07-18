using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCore
{
    public partial class Algorithms
    {
        /// <summary>
        /// Greatest Common Divisor
        /// </summary>
        /// <param name="v"></param>
        /// <param name="u"></param>
        /// <returns></returns>
        public static BigInteger EuclideanAlgorithm(BigInteger u, BigInteger v)
        {
            // Instructions
            // Step 1. Divide first number by the second and find the remainder
            // Step 2. Now switch the numbers - divide the second number by this remainder and find new remainder from this division
            // Step 2.1. Switch the numbers again - divide the first remainder by the second remainder and find the new one
            // Step 2.2. Repeat the previous step until remainder equals 0
            // Step 3. If current remainder is 0, take current divisor as the greatest common divisor

            // Illustration
            // let us find the greatest common divisor between 72 and 40
            // 72 / 40 = 1, remainder is 32
            // 40 / 32 = 1, remainder is 8
            // 32 /  8 = 4, remainder is 0
            // therefore, 8 is the greatest common divisor of 72 and 40

            // Replace the code below with your implementation
            return 0;
        }
    }
}
