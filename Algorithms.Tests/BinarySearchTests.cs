using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace Algorithms.Tests
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void Recurive_Should_Pass()
        {
            int[] numbers = new int[] { 2, 3, 5, 7, 9, 10 };
            BinarySearch bs = new BinarySearch(numbers);
            bs.Search(2, true).Should().Be(0, "Incorrect index for 2");
            bs.Search(5, true).Should().Be(2, "Incorrect index for 5");
            bs.Search(10, true).Should().Be(5, "Incorrect index for 10");
            bs.Search(1, true).Should().Be(-1, "Incorrect index for 1");
            bs.Search(8, true).Should().Be(-1, "Incorrect index for 8");
            bs.Search(20, true).Should().Be(-1, "Incorrect index for 20");
        }

        [TestMethod]
        public void Iterative_Should_Pass()
        {
            int[] numbers = new int[] { 2, 3, 5, 7, 9, 10 };
            BinarySearch bs = new BinarySearch(numbers);
            bs.Search(2, false).Should().Be(0, "Incorrect index for 2");
            bs.Search(5, false).Should().Be(2, "Incorrect index for 5");
            bs.Search(10, false).Should().Be(5, "Incorrect index for 10");
            bs.Search(1, false).Should().Be(-1, "Incorrect index for 1");
            bs.Search(8, false).Should().Be(-1, "Incorrect index for 8");
            bs.Search(20, false).Should().Be(-1, "Incorrect index for 20");
        }

        [TestMethod]
        public void Empty_Should_Pass()
        {
            int[] numbers = new int[] {};
            BinarySearch bs = new BinarySearch(numbers);
            bs.Search(8, true).Should().Be(-1, "Incorrect index for recursive method");
            bs.Search(8, false).Should().Be(-1, "Incorrect index for iterative method");
        }
    }
}
