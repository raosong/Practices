using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BinaryNode<T> where T: IComparable<T>
    {
        public T Value { get; private set; }
        public BinaryNode<T> Left { get; private set; }
        public BinaryNode<T> Right { get; private set; }

        public BinaryNode(T value, BinaryNode<T> left, BinaryNode<T> right)
        {
            this.Value = value;
            this.Left = left;
            this.Right = right;
        }
    }
}
