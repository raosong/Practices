using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;


namespace Algorithms.Tests
{
    [TestClass]
    public class FibTests
    {
        [TestMethod]
        public void Fib_Should_Generate_Recursive_N_6()
        {
            Fib fib = new Fib();
            var fibs = fib.GenerateFibs(6, true);
            fibs.Length.Should().Be(7, "Incorrect length of fib(6).");
            fibs[1].Should().Be(1, "Incorrect value of fib_1");
            fibs[2].Should().Be(1, "Incorrect value of fib_2");
            fibs[3].Should().Be(2, "Incorrect value of fib_3");
            fibs[4].Should().Be(3, "Incorrect value of fib_4");
            fibs[5].Should().Be(5, "Incorrect value of fib_5");
            fibs[6].Should().Be(8, "Incorrect value of fib_6");
        }

        [TestMethod]
        public void Fib_Should_Generate_Iterative_N_6()
        {
            Fib fib = new Fib();
            var fibs = fib.GenerateFibs(6, false);
            fibs.Length.Should().Be(7, "Incorrect length of fib(6).");
            fibs[1].Should().Be(1, "Incorrect value of fib_1");
            fibs[2].Should().Be(1, "Incorrect value of fib_2");
            fibs[3].Should().Be(2, "Incorrect value of fib_3");
            fibs[4].Should().Be(3, "Incorrect value of fib_4");
            fibs[5].Should().Be(5, "Incorrect value of fib_5");
            fibs[6].Should().Be(8, "Incorrect value of fib_6");
        }

    }
}
