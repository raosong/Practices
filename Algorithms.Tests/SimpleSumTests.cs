using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    [TestClass]
    public class SimpleSumTests
    {
        List<Tuple<string, int, int>> testData = new List<Tuple<string, int, int>>() {
                new Tuple<string, int, int>("12", 3, 1),
                new Tuple<string, int, int>("123", 6, 2),
                new Tuple<string, int, int>("99999", 45, 4),
                new Tuple<string, int, int>("9230560001", 71, 4),
                new Tuple<string, int, int>("0123456789", 45, 8),
                new Tuple<string, int, int>("383824", 100, 2),
            };

        [TestMethod]
        public void SimpleSum_Regular_Pass0()
        {
            SimpleSum sim = new SimpleSum();
            int i = 0;
            int plustCount = sim.SimpleSumPlus(testData[i].Item1, testData[i].Item2);
            plustCount.Should().Be(testData[i].Item3, "Incorrect plus count for {0} {1}", testData[i].Item1, testData[i].Item2);
        }

        [TestMethod]
        public void SimpleSum_Regular_Pass1()
        {
            SimpleSum sim = new SimpleSum();
            int i = 1;
            int plustCount = sim.SimpleSumPlus(testData[i].Item1, testData[i].Item2);
            plustCount.Should().Be(testData[i].Item3, "Incorrect plus count for {0} {1}", testData[i].Item1, testData[i].Item2);
        }

        [TestMethod]
        public void SimpleSum_Regular_Pass2()
        {
            SimpleSum sim = new SimpleSum();
            int i = 2;
            int plustCount = sim.SimpleSumPlus(testData[i].Item1, testData[i].Item2);
            plustCount.Should().Be(testData[i].Item3, "Incorrect plus count for {0} {1}", testData[i].Item1, testData[i].Item2);
        }
        [TestMethod]
        public void SimpleSum_Regular_Pass3()
        {
            SimpleSum sim = new SimpleSum();
            int i = 3;
            int plustCount = sim.SimpleSumPlus(testData[i].Item1, testData[i].Item2);
            plustCount.Should().Be(testData[i].Item3, "Incorrect plus count for {0} {1}", testData[i].Item1, testData[i].Item2);
        }
        [TestMethod]
        public void SimpleSum_Regular_Pass4()
        {
            SimpleSum sim = new SimpleSum();
            int i = 4;
            int plustCount = sim.SimpleSumPlus(testData[i].Item1, testData[i].Item2);
            plustCount.Should().Be(testData[i].Item3, "Incorrect plus count for {0} {1}", testData[i].Item1, testData[i].Item2);
        }
        [TestMethod]
        public void SimpleSum_Regular_Pass5()
        {
            SimpleSum sim = new SimpleSum();
            int i = 5;
            int plustCount = sim.SimpleSumPlus(testData[i].Item1, testData[i].Item2);
            plustCount.Should().Be(testData[i].Item3, "Incorrect plus count for {0} {1}", testData[i].Item1, testData[i].Item2);
        }
    }
}
