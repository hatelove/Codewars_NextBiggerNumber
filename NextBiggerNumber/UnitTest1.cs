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

        [TestMethod]
        public void Test_input_is_111_should_be_largestNumber()
        {
            var input = 111;
            var expected = NoLargerNumber;
            var actual = NextLargerNumber.Next(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_input_is_531_should_be_largetNumber()
        {
            var input = 531;
            var expected = NoLargerNumber;
            var actual = NextLargerNumber.Next(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_input_is_345_should_return_354()
        {
            var input = 345;
            var expected = 354;
            var actual = NextLargerNumber.Next(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void input_is_576_should_return_657()
        {
            var input = 576;
            var expected = 657;
            var actual = NextLargerNumber.Next(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_11200_should_return_12001()
        {
            var input = 11200;
            var expected = 12001;
            var actual = NextLargerNumber.Next(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_15963_should_return_16359()
        {
            var input = 15963;
            var expected = 16359;
            var actual = NextLargerNumber.Next(input);
            Assert.AreEqual(expected, actual);
        }
    }

    public static class NextLargerNumber
    {
        public static int Next(int input)
        {
            var inputNumbers = input.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToList();

            for (int index = inputNumbers.Count - 1; index > 0; index--)
            {
                if (inputNumbers[index] > inputNumbers[index - 1])
                {
                    var r = inputNumbers.GetRange(index, inputNumbers.Count - index);
                    var l = inputNumbers.GetRange(0, index);

                    Swap(r, index, l);

                    l.AddRange(r.OrderBy(x => x));

                    return GetNumbericFromValueList(l);
                }
            }

            return -1;
        }

        private static void Swap(List<int> r, int index, List<int> l)
        {
            var t = l[index - 1];
            for (int i = r.Count - 1; i >= 0; i--)
            {
                if (r[i] > t)
                {
                    l[index - 1] = r[i];
                    r[i] = t;
                    break;
                }
            }
        }

        private static int GetNumbericFromValueList(List<int> inputNumbers)
        {
            var count = inputNumbers.Count;

            var result = inputNumbers.Select((x, index) => x * (Math.Pow(10, (count - index - 1)))).Sum();
            return Convert.ToInt32(result);
        }
    }
}