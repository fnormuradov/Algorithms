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
    public class StringHelperTests
    {
        [TestMethod]
        public void ReverseStringTest()
        {
            var initialStrings = new string[] { "12321", "farrukh" };
            var expectedStrings = new string[] { "12321", "hkurraf" };
            for (var i = 0; i < initialStrings.Length; i++)
            {
                var resultingString = StringHelpers.Reverse(initialStrings[i]);
                Assert.AreEqual(expectedStrings[i], resultingString);
            }
        }
    }
}
