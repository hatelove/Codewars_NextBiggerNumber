using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

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

        [TestMethod]
        public void Test_input_is_21_should_be_largestNumber()
        {
            var input = 21;
            var expected = NoLargerNumber;
            var actual = NextLargerNumber.Next(input);

            Assert.AreEqual(expected, actual);
        }
    }

    public static class NextLargerNumber
    {
        public static int Next(int input)
        {
            var inputNumbers = input.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToList();

            if (inputNumbers.Count == 1)
            {
                return -1;
            }

            if (inputNumbers[1] > inputNumbers[0])
            {
                var temp = inputNumbers[1];
                inputNumbers[1] = inputNumbers[0];
                inputNumbers[0] = temp;
            }

            int result = GetNumbericFromValueList(inputNumbers);
            return result == input ? -1 : result;
        }

        private static int GetNumbericFromValueList(List<int> inputNumbers)
        {
            var count = inputNumbers.Count;

            var result = inputNumbers.Select((x, index) => x * (Math.Pow(10, (count - index - 1)))).Sum();
            return Convert.ToInt32(result);
        }
    }
}