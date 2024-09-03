using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class LinkedList
    {
        
        private Node Head;

        public LinkedList()
        {
            Head = null;
        }

        public LinkedList(int data)
        {
            Head = new Node(data);
        }

        //O(n)
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            Node curr = Head;

            while (curr.getNext != null)
            {
                curr = curr.getNext();
            }

            curr.setNext(newNode);
        }

        public string Display()
        {
            if (Head == null)
            {
                return "List is empty";
            }
            Node curr = Head;
            string values = "";
            while (curr.getNext != null)
            {
                values += $" -< {curr.getValue().ToString()}";
                curr = curr.getNext();
            }
            return values;
        }
    }
}
