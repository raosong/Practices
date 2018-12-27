using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Linq;


namespace Algorithms.Tests
{
    [TestClass]
    public class SingleListTests
    {
        private SingleList<int> list;
        private int maxIndex = 4;

        [TestInitialize]
        public void TestSetup()
        {
            this.list = new SingleList<int>();
            for (int i = maxIndex; i >= 0; i--)
            {
                this.list.InsertNode(i);
            }
        }
        [TestMethod]
        public void SingleList_InsertNode_Should_Pass()
        {
            int index = 0;
            foreach (var value in this.list)
            {
                value.Should().Be(index, "Value {0} is incorrect.", index);
                index.Should().BeLessOrEqualTo(this.maxIndex, "More values than expected.");

                index++;
            }
        }

        [TestMethod]
        public void SingleList_Reverse_Should_Pass()
        {
            this.list.Reverse();
            int index = maxIndex;
            foreach (var value in this.list)
            {
                value.Should().Be(index, "Value {0} is incorrect.", index);
                index.Should().BeGreaterOrEqualTo(0, "More values than expected.");

                index--;
            }
        }

        [TestMethod]
        public void SingleList_Reverse_Empty_Should_Pass()
        {
            this.list.Clean();
            this.list.Reverse();
            this.list.Count().Should().Be(0, "Incorrect count");
        }
    }
}
