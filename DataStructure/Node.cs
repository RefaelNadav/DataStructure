using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Node
    {
        private int Value;
        private Node? Next;

        public int getValue()
        {
            return Value;
        }

        public Node getNext()
        {
            return Next;
        }

        public void setValue(int value)
        {
            Value = value;
        }

        public void setNext(Node next)
        {
            Next = next;
        }

        public Node(int data)
        {
            Value = data;
            Next = null;
        }
    }
}
