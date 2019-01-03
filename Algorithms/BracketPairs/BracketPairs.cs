using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BracketPairs
    {
        //This private class is used for iterative generation algorithm only.
        private class QueueItem
        {
            public int Left { get; private set; }
            public int Right { get; private set; }
            public string Value { get; private set; }
            public QueueItem(int left, int right, string value)
            {
                this.Left = left;
                this.Right = right;
                this.Value = value;
            }
        }

        public List<string> GenerateBracketPairs(int n, bool recursive)
        {
            if (n < 0 || n > 20)
            {
                throw new ArgumentException("n must be between 0 and 20 inclusively.");
            }

            List<string> results = new List<string>();

            if (n > 0)
            {
                if (recursive)
                {
                    this.GenerateBracketPairsRecursive(n, 1, 0, "(", results);
                }
                else
                {
                    this.GenerateBracketPairsIterative(n, results);
                }
            }

            return results;
        }


        private void GenerateBracketPairsIterative(int n, List<string> results)
        {
            Queue<QueueItem> q = new Queue<QueueItem>();
            q.Enqueue(new QueueItem(1, 0, "("));

            while (q.Count > 0)
            {
                var item = q.Dequeue();
                if (item.Right == n)
                {
                    results.Add(item.Value);
                }
                else
                {
                    if (item.Left == item.Right)
                    {
                        q.Enqueue(new QueueItem(item.Left + 1, item.Right, item.Value + "("));
                    }
                    else 
                    {
                        if (item.Left > item.Right)
                        {
                            if (item.Left < n)
                            {
                                q.Enqueue(new QueueItem(item.Left + 1, item.Right, item.Value + "("));
                            }

                            q.Enqueue(new QueueItem(item.Left, item.Right + 1, item.Value + ")"));
                        }
                    }
                }
            }
        }

        private void GenerateBracketPairsRecursive(int n, int left, int right, string value, List<string> results)
        {
            if (right == n)
            {
                results.Add(value);
            }
            else
            {
                if (left == right)
                {
                    GenerateBracketPairsRecursive(n, left + 1, right, value + "(", results);
                }
                else
                {
                    if (left > right)
                    {
                        if (left < n)
                        {
                            GenerateBracketPairsRecursive(n, left + 1, right, value + "(", results);
                        }

                        GenerateBracketPairsRecursive(n, left, right + 1, value + ")", results);
                    }
                }
            }
        }

        public List<string> GenerateBracketPairs2(int n)
        {
            if (n == 0)
            {
                return new List<string>();
            }

            if (n == 1)
            {
                return new List<string>() { "()" };
            }

            var lastValues = GenerateBracketPairs2(n - 1);
            var values = new List<string>();
            foreach (var value in lastValues)
            {
                values.Add(string.Format("({0})", value));

                var rightValue = string.Format("{0}()", value);
                var leftValue = string.Format("(){0}", value);

                values.Add(leftValue);
                if (leftValue != rightValue)
                {
                    values.Add(rightValue);
                }
            }

            return values;
        }
    }
}
