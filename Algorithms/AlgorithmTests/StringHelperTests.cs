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

        [TestMethod]
        public void GetDigitsTest()
        {
            Assert.AreEqual(1, StringHelpers.GetDigits(11));
            Assert.AreEqual(2, StringHelpers.GetDigits(1112));
            Assert.AreEqual(6, StringHelpers.GetDigits(115316));
        }
        [TestMethod]
        public void GetDecatesTest()
        {
            Assert.AreEqual(1, StringHelpers.GetDecates(11));
            Assert.AreEqual(1, StringHelpers.GetDecates(1112));
            Assert.AreEqual(1, StringHelpers.GetDecates(115316));
        }
        [TestMethod]
        public void GetHunderdsTest()
        {
            Assert.AreEqual(2, StringHelpers.GetHundreds(222));
            Assert.AreEqual(3, StringHelpers.GetHundreds(322));
            Assert.AreEqual(9, StringHelpers.GetHundreds(115916));
        }
        private List<Tuple<int, string>> Spellings = new List<Tuple<int, string>>()
        {
            new Tuple<int, string>(1,"one"),
            new Tuple<int, string>(2,"two"),
            new Tuple<int, string>(3,"three"),
            new Tuple<int, string>(4,"four"),
            new Tuple<int, string>(5,"five"),
            new Tuple<int, string>(6,"six"),
            new Tuple<int, string>(7,"seven"),
            new Tuple<int, string>(8,"eight"),
            new Tuple<int, string>(9,"nine"),
            new Tuple<int, string>(10,"ten"),
            new Tuple<int, string>(11,"eleven"),
            new Tuple<int, string>(12,"twelve"),
            new Tuple<int, string>(13,"thirteen"),
            new Tuple<int, string>(14,"fourteen"),
            new Tuple<int, string>(15,"fifteen"),
            new Tuple<int, string>(16,"sixteen"),
            new Tuple<int, string>(17,"seventeen"),
            new Tuple<int, string>(18,"eighteen"),
            new Tuple<int, string>(19,"nineteen"),
            new Tuple<int, string>(20,"twenty"),
            new Tuple<int, string>(30,"thirty"),
            new Tuple<int, string>(21,"twenty-one"),
            new Tuple<int, string>(22,"twenty-two"),
            new Tuple<int, string>(23,"twenty-three"),
            new Tuple<int, string>(34,"thirty-four"),
            new Tuple<int, string>(45,"forty-five"),
            new Tuple<int, string>(40,"forty"),
            new Tuple<int, string>(56,"fifty-six"),
            new Tuple<int, string>(50,"fifty"),
            new Tuple<int, string>(67,"sixty-seven"),
            new Tuple<int, string>(60,"sixty"),
            new Tuple<int, string>(78,"seventy-eight"),
            new Tuple<int, string>(70,"seventy"),
            new Tuple<int, string>(89,"eighty-nine"),
            new Tuple<int, string>(80,"eighty"),
            new Tuple<int, string>(98,"ninety-eight"),
            new Tuple<int, string>(90,"ninety"),
            new Tuple<int, string>(100,"one hundred"),
            new Tuple<int, string>(101,"one hundred and one"),
            new Tuple<int, string>(120,"one hundred and twenty"),
            new Tuple<int, string>(200,"two hundred"),
            new Tuple<int, string>(300,"three hundred"),
            new Tuple<int, string>(568,"five hundred and sixty-eight"),
            new Tuple<int, string>(1000,"one thousand"),
        };
        [TestMethod]
        public void TestRunner()
        {
            foreach (var tuple in Spellings)
            {
                var number = tuple.Item1;
                var spelling = tuple.Item2;
                GenericWordTest(number, spelling);
            }
        }
        public void GenericWordTest(int n, string spelling)
        {
            var resultSpelling = StringHelpers.SpellNumber(n);
            Assert.AreEqual(spelling, resultSpelling);
        }
    }
}
