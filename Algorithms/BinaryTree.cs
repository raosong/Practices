using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public enum TraverseType
    {
        PreOrder,
        InOrder,
        PostOrder,
        LevelOrder
    }

    public class BinaryTree<T> where T : IComparable<T>
    {

        public BinaryNode<T> Root { get; private set; }

        public BinaryTree(BinaryNode<T> root)
        {
            this.Root = root;
        }

        public List<T> Traverse(TraverseType traverseType)
        {
            List<T> result = new List<T>();

            if (traverseType == TraverseType.PreOrder)
            {
                this.PreOrder(this.Root, result);
            }
            else if (traverseType == TraverseType.InOrder)
            {
                this.InOrder(this.Root, result);
            }
            else if (traverseType == TraverseType.PostOrder)
            {
                this.PostOrder(this.Root, result);
            }
            else if (traverseType == TraverseType.LevelOrder)
            {
                this.LevelOrder(this.Root, result);
            }

            return result;
        }

        private void PreOrder(BinaryNode<T> root, List<T> result)
        {
            if (root == null)
            {
                return;
            }
            else
            {
                result.Add(root.Value);
                PreOrder(root.Left, result);
                PreOrder(root.Right, result);
            }
        }
        private void InOrder(BinaryNode<T> root, List<T> result)
        {
            if (root == null)
            {
                return;
            }
            else
            {
                InOrder(root.Left, result);
                result.Add(root.Value);
                InOrder(root.Right, result);
            }
        }
        private void PostOrder(BinaryNode<T> root, List<T> result)
        {
            if (root == null)
            {
                return;
            }
            else
            {
                PostOrder(root.Left, result);
                PostOrder(root.Right, result);
                result.Add(root.Value);
            }
        }

        private void LevelOrder(BinaryNode<T> root, List<T> result)
        {
            if (root == null)
            {
                return;
            }

            Queue<BinaryNode<T>> q = new Queue<BinaryNode<T>>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                var node = q.Dequeue();
                result.Add(node.Value);
                if (node.Left != null)
                {
                    q.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    q.Enqueue(node.Right);
                }
            }
        }

        public int GetDepth(AlgorithmType algType)
        {
            int maxLevel = 0;

            if (algType == AlgorithmType.Iterative)
            {
                maxLevel = this.GetDepthInterative(this.Root);
            }
            else
            {
                this.GetDepthInRecursive(this.Root, 0, ref maxLevel);
            }

            return maxLevel;
        }

        public List<T> GetLongestPath()
        {
            List<T> longestPath = new List<T>();
            GetLongestPath(this.Root, new List<T>(), ref longestPath);
            return longestPath;
        }

        private int GetDepthInterative(BinaryNode<T> root)
        {
            if (root == null)
            {
                return 0;
            }

            int depth = 0;

            Queue<Tuple<BinaryNode<T>, int>> q = new Queue<Tuple<BinaryNode<T>, int>>();
            q.Enqueue(new Tuple<BinaryNode<T>, int>(root, 1));
            while (q.Count > 0)
            {
                var node = q.Dequeue();

                if (node.Item2 > depth)
                {
                    depth = node.Item2;
                }

                if (node.Item1.Left != null)
                {
                    q.Enqueue(new Tuple<BinaryNode<T>, int>(node.Item1.Left, node.Item2 + 1));
                }

                if (node.Item1.Right != null)
                {
                    q.Enqueue(new Tuple<BinaryNode<T>, int>(node.Item1.Right, node.Item2 + 1));
                }
            }

            return depth;
        }

        private void GetDepthInRecursive(BinaryNode<T> root, int level, ref int maxLevel)
        {
            if (root == null)
            {
                return;
            }

            level++;

            if (maxLevel < level)
            {
                maxLevel = level;
            }

            if (root.Left != null)
            {
                GetDepthInRecursive(root.Left, level, ref maxLevel);
            }

            if (root.Right != null)
            {
                GetDepthInRecursive(root.Right, level, ref maxLevel);
            }
        }

        private void GetLongestPath(BinaryNode<T> root, List<T> path, ref List<T> longestPath)
        {
            if (root == null)
            {
                return;
            }

            path.Add(root.Value);

            if (longestPath.Count < path.Count)
            {
                longestPath = path;
            }

            if (root.Left != null)
            {
                GetLongestPath(root.Left, new List<T>(path), ref longestPath);
            }

            if (root.Right != null)
            {
                GetLongestPath(root.Right, new List<T>(path), ref longestPath);
            }
        }
    }
}
