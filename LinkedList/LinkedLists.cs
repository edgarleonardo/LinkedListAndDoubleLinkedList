using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedLists
    {
        public Node Root;
        public Node Tail;
        public int count { get; private set; }

        public void AddLast(object objects)
        {
            Node value = new Node(objects);
            if (Root == null)
            {
                Root = value;
                Tail = value;
            }
            else
            {
                Tail.next = value;
                Tail = Tail.next;
            }
            count++;
        }

        public void AddFirst(object objects)
        {
            Node value = new Node(objects);
            if (Root == null)
            {
                Root = value;
                Tail = value;
            }
            else
            {
                value.next = Root;
                Root = value;
            }
            count++;
        }

        public bool Contains(string item)
        {
            Node SearcNode = Root;
            bool result = false;
            if (SearcNode != null)
            {
                while (SearcNode != null)
                {
                    if (SearcNode.value.ToString().Equals(item))
                    {
                        result = true;
                        break;
                    }
                    SearcNode = SearcNode.next;
                }
            }

            return result;
        }

        public void CopyTo(object[] array, int arrayIndex)
        {
            Node current = Root;
            while (current != null)
            {
                array[arrayIndex++] = current.value;
                current = current.next;
            }
        }
        public void Remove(object objects)
        {            
            if (Root != null && Root.value ==objects)
            {
                RemoveFirst();
            }
            else if (Tail != null && Tail.value == objects)
            {
                RemoveLast();
            }
            else
            {
                Node start = Root;
                while (start.next != null)
                {
                    if (start.next.value == objects)
                    {
                        Node temp = start.next;
                        start.next = start.next.next;
                        temp.next = null;
                        break;
                    }
                    start = start.next;                    
                }
            }                
        }
        public void RemoveFirst()
        {
            if (count > 0)
            {
                if (count == 1)
                {
                    Root = null;
                    Tail = null;
                }
                else
                {
                    Node temp = Root.next;
                    Root.next = null;
                    Root = temp;
                }                
                count--;
            }            
        }
        public void RemoveLast()
        {
            if (count > 0)
            {
                if (count == 1)
                {
                    Root = null;
                    Tail = null;
                }
                else
                {
                    Node temp = Root;
                    while (temp.next != Tail)
                    {
                        temp = temp.next;
                    }
                    temp.next = null;
                    Tail = temp;
                }
                count--;
            }
        }
        public IEnumerable<string> GetEnumerator()
        {
            Node current = Root;
            while (current != null)
            {
                yield return current.value.ToString();
                current = current.next;
            }
        }
        public void Clear()
        {
            Root = null;
            Tail = null;
        }
    }
}
