using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace AlgorithmsCore
{
    public static partial class Algorithms
    {
        /// <summary>
        /// ax = 1 (mod m)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="m"></param>
        /// <returns>x</returns>
        public static BigInteger GetModularMultiplicativeInverse(BigInteger a, BigInteger m)
        {
            //Verify that a and m are coprime
            //If they are not - the inverse does not exist. Throw an exception.
            //In other cases return the last element in the array returned by ExtendedEuclideanAlgorithm method, which is the Modular Multiplicative Inverse
            throw new NotImplementedException();
        }

        /// <summary>
        /// See: https://en.wikipedia.org/wiki/Extended_Euclidean_algorithm
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>The array containing [r, s, t], where r is the greatest common divisor, s and t are coefficients
        /// in the equation as+bt=r</returns>
        public static BigInteger[] ExtendedEuclideanAlgorithm(BigInteger a, BigInteger b)
        {
            //Prepare the array to store x, y and r
            // Select min and max numbers so that division is correct
            // If a less than b, switch them

            //Prepare the following integers r(=b), q(=0), x_0(=1), y_0(=0)
            //x_1(=0), y_1(=1), x(=0), y(=0)

            //Do the following while r > 1

            //Set r to be the remainer of the divison a by b
            //Set q to be equal to the whole division of a by b
            //Set x: x_0 - qx_1
            //Set  y: y_0 - qy_1
            // Set x_0: x_1
            // Set y_0: y_1
            //Set x_1: x
            //Set y_1: y
            //Set a:b
            //Set b:r
            // If r is 0 return the array {a, x, y}. In other cases return {r, x, y}. Note that order is critical.
            throw new NotImplementedException();
        }
    }
}
