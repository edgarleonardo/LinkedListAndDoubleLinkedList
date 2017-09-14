using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    public class DoubleLinkedLists<T>
    {
        public Node<T> Root { get; private set; }
        public Node<T> Tail { get; private set; }

        public DoubleLinkedLists()
        {

        }
        public void Clear()
        {
            Root = null;
            Tail = null;
        }
        public void AddFirst(T data)
        {
            Node<T> temp = new Node<T>(data);
            temp.Next = Root;
            if (Root == null)
            {
                Root = temp;                
                Tail = Root;
            }
            else
            {
                Root.Previous = temp;
                Root = temp;
            }
        }

        /// <summary>
        /// Enumerates over the linked list values from Head to Tail
        /// </summary>
        /// <returns>A Head to Tail enumerator</returns>
        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = Root;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        public void AddLast(T data)
        {
            Node<T> temp = new Node<T>(data);
            temp.Previous = Tail;
            if (Tail == null)
            {
                Tail = temp;
                Root = temp;
            }
            else
            {
                Tail.Next = temp;
                Tail = temp;
            }
        }

        public void RemoveFirst()
        {
            if (Root != null)
            {
                Node<T> nxtNode = Root.Next;
                nxtNode.Previous = Root.Next = null;
                Root = nxtNode;
            }
        }

        public void RemoveLast()
        {
            if (Tail != null)
            {
                Node<T> prevNode = Tail.Previous;
                Tail = prevNode;
                prevNode.Next = Tail.Previous = null;                
            }
        }

        public bool RemoveNode(T Element)
        {
            if (Root == null)
                return false;

            Node<T> nodeToDelete = SearchNode(Element);

            if (nodeToDelete != null)
            {
                if (nodeToDelete.Equals(Root))
                {
                    RemoveFirst();
                }
                else if (nodeToDelete.Equals(Tail))
                {
                    RemoveLast();
                }
                else
                {
                    var nodeTemp = nodeToDelete.Next;
                    nodeToDelete.Previous.Next = nodeTemp;
                    nodeTemp.Previous = nodeToDelete.Previous;
                }
                return true;
            }
            return false;
        }

        private Node<T> SearchNode(T Element)
        {
            if (Root != null)
            {
                Node<T> elementToFind = Root;
                while (elementToFind != null)
                {
                    if (elementToFind.Value.Equals(Element))
                    {
                        return elementToFind;
                    }
                    elementToFind = elementToFind.Next;
                }
            }
            return null;
        }
    }
}
