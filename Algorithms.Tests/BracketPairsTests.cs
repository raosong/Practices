using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;


namespace Algorithms.Tests
{
    [TestClass]
    public class BracketPairsTests
    {
        [TestMethod]
        public void BracketPairs_Should_Generate_N_0()
        {
            BracketPairs bp = new BracketPairs();

            var results = bp.GenerateBracketPairs(0, true);
            results.Should().NotBeNull("results should not be null with n = 0 in recursive");
            results.Count.Should().Be(0, "results should have exactly 0 result with n = 0 in recursive");

            results = bp.GenerateBracketPairs(0, false);
            results.Should().NotBeNull("results should not be null with n = 0 in iterative");
            results.Count.Should().Be(0, "results should have exactly 0 result with n = 0 in iterative");
        }

        [TestMethod]
        public void BracketPairs_Should_Generate_N_1()
        {
            BracketPairs bp = new BracketPairs();

            var results = bp.GenerateBracketPairs(1, true);
            results.Should().NotBeNull("results should not be null with n = 1 in recursive");
            results.Count.Should().Be(1, "results should have exactly 1 result with n = 1 in recursive");
            results[0].Should().Be("()", "results was not incorrect with n = 1 in recursive");

            results = bp.GenerateBracketPairs(1, false);
            results.Should().NotBeNull("results should not be null with n = 1 in iterative");
            results.Count.Should().Be(1, "results should have exactly 1 result with n = 1 in iterative");
            results[0].Should().Be("()", "results was not incorrect with n = 1 in iterative");
        }

        [TestMethod]
        public void BracketPairs_Should_Generate_N_3()
        {
            BracketPairs bp = new BracketPairs();

            var results = bp.GenerateBracketPairs(3, true);
            results.Should().NotBeNull("results should not be null with n = 3 in recursive");
            results.Count.Should().Be(5, "results should have exactly 5 results with n = 3 in recursive");
            results.Contains("((()))").Should().BeTrue("results does not contain value ((())) with n = 3 in recursive");
            results.Contains("(())()").Should().BeTrue("results does not contain value (())() with n = 3 in recursive");
            results.Contains("()(())").Should().BeTrue("results does not contain ()(()) with n = 3 in recursive");
            results.Contains("(()())").Should().BeTrue("results does not contain value (()()) with n = 3 in recursive");
            results.Contains("()()()").Should().BeTrue("results does not contain value ()()() with n = 3 in recursive");

            results = bp.GenerateBracketPairs(3, false);
            results.Should().NotBeNull("results should not be null with n = 3 in iterative");
            results.Count.Should().Be(5, "results should have exactly 5 results with n = 3 in iterative");
            results.Contains("((()))").Should().BeTrue("results does not contain value ((())) with n = 3 in iterative");
            results.Contains("(())()").Should().BeTrue("results does not contain value (())() with n = 3 in iterative");
            results.Contains("()(())").Should().BeTrue("results does not contain ()(()) with n = 3 in iterative");
            results.Contains("(()())").Should().BeTrue("results does not contain value (()()) with n = 3 in iterative");
            results.Contains("()()()").Should().BeTrue("results does not contain value ()()() with n = 3 in iterative");
        }

        [TestMethod]
        public void BracketPairs_Should_Generate2_N_3()
        {
            BracketPairs bp = new BracketPairs();

            var results = bp.GenerateBracketPairs2(3);
            results.Should().NotBeNull("results should not be null with n = 3 in recursive2");
            results.Count.Should().Be(5, "results should have exactly 5 results with n = 3 in recursive2");
            results.Contains("((()))").Should().BeTrue("results does not contain value ((())) with n = 3 in recursive2");
            results.Contains("(())()").Should().BeTrue("results does not contain value (())() with n = 3 in recursive2");
            results.Contains("()(())").Should().BeTrue("results does not contain ()(()) with n = 3 in recursive2");
            results.Contains("(()())").Should().BeTrue("results does not contain value (()()) with n = 3 in recursive2");
            results.Contains("()()()").Should().BeTrue("results does not contain value ()()() with n = 3 in recursive2");
        }

        [TestMethod]
        public void BracketPairs_Should_Generate2_N_2()
        {
            BracketPairs bp = new BracketPairs();

            var results = bp.GenerateBracketPairs2(2);
            results.Should().NotBeNull("results should not be null with n = 2 in recursive2");
            results.Count.Should().Be(2, "results should have exactly 2 results with n = 2 in recursive2");
            results.Contains("(())").Should().BeTrue("results does not contain value (()) with n = 2 in recursive2");
            results.Contains("()()").Should().BeTrue("results does not contain value ()() with n = 2 in recursive2");
        }
    }
}
