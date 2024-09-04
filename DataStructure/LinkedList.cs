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

            while (curr.getNext() != null)
            {
                curr = curr.getNext();
            }

            curr.setNext(newNode);
        }

        //o(n)
        public string Display()
        {
            if (Head == null)
            {
                return "List is empty";
            }
            Node curr = Head;
            string values = "";
            while (curr.getNext() != null)
            {
                values += $"{curr.getValue().ToString()} -> ";
                curr = curr.getNext();
            }
            values += curr.getValue();
            return values;
        }

        public int Length() 
        {
            if (Head == null)
            {
                return 0;
            }
            Node curr = Head;
            int counter = 0;
            while (curr != null)
            {
                counter ++;
                curr = curr.getNext();
            }

            return counter;
        }

        public void RemoveAllValues(int data)
        {
            if(Head == null)
            {
                return;
            }

            while (Head != null && Head.getValue() == data)
            {
                Head = Head.getNext();
            }
            Node curr = Head;

            Node prev = Head;
            while (curr != null)
            {
                if(curr.getValue() == data)
                {
                    prev.setNext(curr.getNext());
                }
                else
                {
                    prev = curr;
                }
                curr = curr.getNext();
            }

            return;
        }
    }
}
