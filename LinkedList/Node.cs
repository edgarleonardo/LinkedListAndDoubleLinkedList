using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public Node next { get; set; }
        public object value { get; set; }
        public Node(object value)
        {
            this.value = value;
        }
    }
}
