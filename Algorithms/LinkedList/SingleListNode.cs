using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SingleListNode<T> where T:IComparable<T>
    {
        public T Value { get; private set; }
        public SingleListNode<T> Next { get; set; }

        public SingleListNode(T value)
        {
            this.Value = value;
            this.Next = null;
        }
    }
}
