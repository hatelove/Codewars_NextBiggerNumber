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
    }

    public static class NextLargerNumber
    {
        public static int Next(int input)
        {
            throw new NotImplementedException();
        }
    }
}
