using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests
{
    [TestClass]
    public class ModularMultiplicativeInverseTests
    {
        [TestMethod]
        public void ModularMultiplicativeInverseTest1()
        {
            Assert.AreEqual(9, Algorithms.GetModularMultiplicativeInverse(26, 3));
        }

        [TestMethod]
        public void ModularMultiplicativeInverseTest2()
        {
            Assert.AreEqual(15, Algorithms.GetModularMultiplicativeInverse(3, 22));
        }
    }
}
