using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    [TestClass]
    public class ChessQueenTests
    {
        [TestMethod]
        public void ChessQueen_Existing4_Test()
        {
            ChessQueen cq = new ChessQueen();
            var result = cq.PlaceQueen(4);
            result.Should().NotBeNull("Result should not be null.");
            result[0].Should().Be(1, "Result[0] is incorrect.");
            result[1].Should().Be(3, "Result[1] is incorrect.");
            result[2].Should().Be(0, "Result[2] is incorrect.");
            result[3].Should().Be(2, "Result[3] is incorrect.");
        }

        [TestMethod]
        public void ChessQueen_Existing1_Test()
        {
            ChessQueen cq = new ChessQueen();
            var result = cq.PlaceQueen(1);
            result.Should().NotBeNull("Result should not be null.");
            result[0].Should().Be(0, "Result[0] is incorrect.");
        }

        [TestMethod]
        public void ChessQueen_NotExisting3_Test()
        {
            ChessQueen cq = new ChessQueen();
            var result = cq.PlaceQueen(3);
            result.Should().BeNull("Result should be null.");
        }

        [TestMethod]
        public void ChessQueen_Existing8_Test()
        {
            ChessQueen cq = new ChessQueen();
            var result = cq.PlaceQueen(8);
            result.Should().NotBeNull("Result should not be null.");
            result[0].Should().Be(0, "Result[0] is incorrect.");
            result[1].Should().Be(4, "Result[1] is incorrect.");
            result[2].Should().Be(7, "Result[2] is incorrect.");
            result[3].Should().Be(5, "Result[3] is incorrect.");
            result[4].Should().Be(2, "Result[4] is incorrect.");
            result[5].Should().Be(6, "Result[5] is incorrect.");
            result[6].Should().Be(1, "Result[6] is incorrect.");
            result[7].Should().Be(3, "Result[7] is incorrect.");
        }
    }
}
