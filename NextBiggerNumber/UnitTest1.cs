using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NextBiggerNumber
{
    [TestClass]
    public class UnitTest1
    {
        private const int NoLargerNumber = -1;

        [TestMethod]
        public void Test_1_should_be_largestNumber()
        {
            var input = 1;

            var expected = NoLargerNumber;

            int actual = NextLargerNumber.Next(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_9_should_be_largestNumber()
        {
            var input = 9;

            var expected = NoLargerNumber;

            int actual = NextLargerNumber.Next(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_input_is_12_should_return_21()
        {
            var input = 12;
            var expected = 21;

            var actual = NextLargerNumber.Next(input);
            Assert.AreEqual(expected, actual);
        }
    }

    public static class NextLargerNumber
    {
        public static int Next(int input)
        {
            return -1;            
        }
    }
}
