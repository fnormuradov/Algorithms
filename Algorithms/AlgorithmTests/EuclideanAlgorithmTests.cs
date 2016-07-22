using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.ExceptionServices;
using AlgorithmsCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AlgorithmTests
{
    [TestClass]
    public class EuclideanAlgorithmTests
    {
        [TestMethod]
        public void EuclideanAlgorithm()
        {
            Assert.AreEqual(15, Algorithms.ExtendedEuclideanAlgorithm(45, 60)[0]);
            Assert.AreEqual(3, Algorithms.ExtendedEuclideanAlgorithm(3999, 10023)[0]);
            Assert.AreEqual(1, Algorithms.ExtendedEuclideanAlgorithm(2342346, 23423561)[0]);
            Assert.AreEqual(1, Algorithms.ExtendedEuclideanAlgorithm(3746382641, 9048472518)[0]);
            Assert.AreEqual(3, Algorithms.ExtendedEuclideanAlgorithm(81, 21)[0]);
        }
    }
}
