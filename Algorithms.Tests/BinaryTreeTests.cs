using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Collections.Generic;

namespace Algorithms
{
    [TestClass]
    public class BinaryTreeTests
    {
        [TestMethod]
        public void BinaryTree_PreOrder_Should_Pass()
        {
            var root = this.CreateTestTree();
            var t = new BinaryTree<int>(root);
            var result = t.Traverse(TraverseType.PreOrder);
            result.Should().NotBeNull("result should not be null.");
            result.Count.Should().Be(7, "Incorrect number of items in result.");
            List<int> expected = new List<int> { 1, 2, 4, 5, 7, 3, 6 };
            for (int i = 0; i < 7; i++)
            {
                result[i].Should().Be(expected[i], "Incorrect result at position {0}", i);
            }
        }

        [TestMethod]
        public void BinaryTree_InOrder_Should_Pass()
        {
            var root = this.CreateTestTree();
            var t = new BinaryTree<int>(root);
            var result = t.Traverse(TraverseType.InOrder);
            result.Should().NotBeNull("result should not be null.");
            result.Count.Should().Be(7, "Incorrect number of items in result.");
            List<int> expected = new List<int> { 4, 2, 5, 7, 1, 6, 3 };
            for (int i = 0; i < 7; i++)
            {
                result[i].Should().Be(expected[i], "Incorrect result at position {0}", i);
            }
        }

        [TestMethod]
        public void BinaryTree_PostOrder_Should_Pass()
        {
            var root = this.CreateTestTree();
            var t = new BinaryTree<int>(root);
            var result = t.Traverse(TraverseType.PostOrder);
            result.Should().NotBeNull("result should not be null.");
            result.Count.Should().Be(7, "Incorrect number of items in result.");
            List<int> expected = new List<int> { 4, 7, 5, 2, 6, 3, 1 };
            for (int i = 0; i < 7; i++)
            {
                result[i].Should().Be(expected[i], "Incorrect result at position {0}", i);
            }
        }

        [TestMethod]
        public void BinaryTree_LevelOrder_Should_Pass()
        {
            var root = this.CreateTestTree();
            var t = new BinaryTree<int>(root);
            var result = t.Traverse(TraverseType.LevelOrder);
            result.Should().NotBeNull("result should not be null.");
            result.Count.Should().Be(7, "Incorrect number of items in result.");
            List<int> expected = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            for (int i = 0; i < 7; i++)
            {
                result[i].Should().Be(expected[i], "Incorrect result at position {0}", i);
            }
        }

        [TestMethod]
        public void BinaryTree_Depth_Iterative_Should_Pass()
        {
            var root = this.CreateTestTree();
            var t = new BinaryTree<int>(root);
            int depth = t.GetDepth(AlgorithmType.Iterative);
            depth.Should().Be(4, "depth is incorrect.");
        }

        [TestMethod]
        public void BinaryTree_Depth_Recursive_Should_Pass()
        {
            var root = this.CreateTestTree();
            var t = new BinaryTree<int>(root);
            int depth = t.GetDepth(AlgorithmType.Recursive);
            depth.Should().Be(4, "depth is incorrect.");
        }

        [TestMethod]
        public void BinaryTree_LongestPath_Should_Pass()
        {
            var root = this.CreateTestTree();
            var t = new BinaryTree<int>(root);
            var result = t.GetLongestPath();
            result.Should().NotBeNull("result should not be null.");
            result.Count.Should().Be(4, "Incorrect number of items in the longest path.");
            List<int> expected = new List<int> { 1, 2, 5, 7 };
            for (int i = 0; i < 4; i++)
            {
                result[i].Should().Be(expected[i], "Incorrect result at position {0}", i);
            }
        }

        /*          
         *          1
         *         /  \
         *        2    3
         *       / \  /
         *      4   5 6
         *           \
         *            7
        */
        private BinaryNode<int> CreateTestTree()
        {
            var n7 = new BinaryNode<int>(7, null, null);
            var n5 = new BinaryNode<int>(5, null, n7);
            var n4 = new BinaryNode<int>(4, null, null);
            var n2 = new BinaryNode<int>(2, n4, n5);
            var n6 = new BinaryNode<int>(6, null, null);
            var n3 = new BinaryNode<int>(3, n6, null);
            var n1 = new BinaryNode<int>(1, n2, n3);
            return n1;
        }
    }
}
