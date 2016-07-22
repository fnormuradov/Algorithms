using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests
{
    [TestClass]
    public class ExtendedEuclideanAlgorithmTests
    {
        [TestMethod]
        public void ExtendedEuclideanAlgorithmTest1()
        {
            var actual = Algorithms.ExtendedEuclideanAlgorithm(8, 11);
            var expected = new BigInteger[] { 1, 3, -4 };
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ExtendedEuclideanAlgorithmTest2()
        {
            var actual = Algorithms.ExtendedEuclideanAlgorithm(50, 71);
            var expected = new BigInteger[] { 1, -19, 27 };
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ExtendedEuclideanAlgorithmTest3()
        {
            var actual = Algorithms.ExtendedEuclideanAlgorithm(234343, 71324);
            var expected = new BigInteger[] { 1, 19579, -64329 };
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ExtendedEuclideanAlgorithmTest4()
        {
            var actual = Algorithms.ExtendedEuclideanAlgorithm(71324, 234343);
            var expected = new BigInteger[] { 1, 19579, -64329 };
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
