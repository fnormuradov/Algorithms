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
            Assert.AreEqual(15, Algorithms.EuclideanAlgorithm(45, 60));
            Assert.AreEqual(3, Algorithms.EuclideanAlgorithm(3999, 10023));
            Assert.AreEqual(1, Algorithms.EuclideanAlgorithm(2342346, 23423561));
            Assert.AreEqual(1, Algorithms.EuclideanAlgorithm(3746382641, 9048472518));
            Assert.AreEqual(3, Algorithms.EuclideanAlgorithm(81, 21));
        }
    }
}
