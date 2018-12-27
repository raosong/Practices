using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SingleList <T> : IEnumerable<T> where T: IComparable<T>
    {
        public SingleListNode<T> Head { get; private set; }

        public void Clean()
        {
            this.Head = null;
        }

        public void InsertNode(T value)
        {
            SingleListNode<T> Node = new SingleListNode<T>(value);
            Node.Next = this.Head;
            this.Head = Node;
        }

        public void Reverse()
        {
            SingleListNode<T> p1 = null;
            SingleListNode<T> p2 = null;
            p1 = this.Head;

            if (p1 != null)
            {
                p2 = p1.Next;
            }

            while (p2 != null)
            {
                p1.Next = p2.Next;

                p2.Next = this.Head;
                this.Head = p2;

                p2 = p1.Next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            var p = this.Head;
            while (p != null)
            {
                yield return p.Value;
                p = p.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
}
