using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    [TestClass]
    public class SubSetSumTests
    {
        [TestMethod]
        public void SubSetSum_Recursive_Existing_Test1()
        {
            SubSetSum ss = new SubSetSum();
            var result = ss.IsSubsetSumRecursive(new int[] { 1, 2, 3 }, 4);
            result.Should().BeTrue("Incorrect result for { 1, 2, 3 }, 4");
        }

        [TestMethod]
        public void SubSetSum_Recursive_NotExisting_Test1()
        {
            SubSetSum ss = new SubSetSum();
            var result = ss.IsSubsetSumRecursive(new int[] { 2, 4 }, 3);
            result.Should().BeFalse("Incorrect result for { 2, 4 }, 3");
        }

        [TestMethod]
        public void SubSetSum_Memo_Existing_Test1()
        {
            SubSetSum ss = new SubSetSum();
            var result = ss.IsSubSetSumMemo(new int[] { 3, 34, 4, 12, 5, 2 }, 9);
            result.Should().BeTrue("Incorrect result for { 3, 34, 4, 12, 5, 2 }, 9");
        }

        [TestMethod]
        public void SubSetSum_DP_Existing_Test1()
        {
            SubSetSum ss = new SubSetSum();
            var result = ss.IsSubSetSumDP(new int[] { 3, 34, 4, 12, 5, 2 }, 9);
            result.Should().BeTrue("Incorrect result for { 3, 34, 4, 12, 5, 2 }, 9");
        }

        [TestMethod]
        public void SubSetSum_DP_NotExisting_Test1()
        {
            SubSetSum ss = new SubSetSum();
            var result = ss.IsSubSetSumDP(new int[] { 3, 34, 4, 12, 5, 2 }, 13);
            result.Should().BeFalse("Incorrect result for { 3, 34, 4, 12, 5, 2 }, 13");
        }

        [TestMethod]
        public void SubSetSum_DP_PrintSets_Test1()
        {
            SubSetSum ss = new SubSetSum();
            var result = ss.PrintSets(new int[] { 1, 2, 3, 4, 5, 6 }, 6);
            result.Should().NotBeNull("result should not be null.");
            result.Count.Should().Be(4, "Incorrect number of results.");
            result[0][0].Should().Be(1, "Incorrect result for result[0][0]");
            result[0][1].Should().Be(2, "Incorrect result for result[0][1]");
            result[0][2].Should().Be(3, "Incorrect result for result[0][2]");
            result[1][0].Should().Be(2, "Incorrect result for result[1][0]");
            result[1][1].Should().Be(4, "Incorrect result for result[1][1]");
            result[2][0].Should().Be(1, "Incorrect result for result[2][0]");
            result[2][1].Should().Be(5, "Incorrect result for result[2][1]");
            result[3][0].Should().Be(6, "Incorrect result for result[3][0]");
        }
    }
}
