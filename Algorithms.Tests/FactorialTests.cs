using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;


namespace Algorithms.Tests
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        public void Factorial_Should_Generate_N_4()
        {
            Factorial fact = new Factorial();
            int result = fact.Fact(4);
            result.Should().Be(24, "Incorrect result.");
        }
    }
}
