using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfShortLib
{
    public class ListOfShort
    {
        private Node _head;                     // head of the list
        public static Node CreateNode(short number)     // create a node
        {
            Node newNode = new Node
            {
                Number = number,
                Next = null
            };
            return newNode;
        }
        public void AddLast(Node newNode)       // add a node to the list
        {
            if (newNode != null)
            {
                if (_head == null)              // for empty lists
                {
                    _head = newNode;
                }
                else
                {
                    Node temp = _head;
                    while (temp.Next != null)
                        temp = temp.Next;
                    temp.Next = newNode;
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(newNode), "Node cannot be null");
            }
        }
        public void DeleteNode(Node toDeletion)         // delete a node
        {
            if (toDeletion != null)
            {
                Node temp = _head;
                if (_head == toDeletion)                // if we want to delete a head of the list
                {
                    _head = toDeletion.Next;
                }
                else
                {
                    while (temp != null && temp.Next != toDeletion)
                        temp = temp.Next;
                    if (temp != null)
                        temp.Next = toDeletion.Next;
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(toDeletion), "Node cannot be null");
            }
        }
        public Node Find(short number)                  // returns a Node if found, null if not
        {
            Node temp = _head;
            while (temp != null && temp.Number != number)
                temp = temp.Next;
            return temp;
        }
        public int GetLength()                          // length of the list
        {
            int length = 0;
            Node temp = _head;
            while (temp != null)
            {
                temp = temp.Next;
                length++;
            }
            return length;
        }
        public int CountMultiplesOfSeven()              // count, how many numbers in array can be divided by 7
        {
            int quantity = 0;
            Node temp = _head;
            while (temp != null)
            {
                if (temp.Number % 7 == 0)
                    quantity++;
                temp = temp.Next;
            }
            return quantity;
        }
        public double GetAverage()                      // average of all elements in array
        {
            double average = 0;
            Node temp = _head;
            while (temp != null)
            {
                average += temp.Number;
                temp = temp.Next;
            }
            if (GetLength() != 0)
                average /= GetLength();
            return average;
        }
        public void ChangeMoreThanAverageToZero()       // all elements that are higher than average are changed to 0
        {
            double average = GetAverage();
            Node temp = _head;
            while (temp != null)
            {
                if (temp.Number > average)
                    temp.Number = 0;
                temp = temp.Next;
            }
        }
        public short this[int index]                    // indexator
        {
            get
            {
                if (index >= 0)
                {
                    int currentIndex = 0;
                    Node temp = _head;
                    if (temp != null)
                    {
                        while (temp.Next != null && currentIndex != index)
                        {
                            currentIndex++;
                            temp = temp.Next;
                        }
                        if (temp != null)
                            return temp.Number;
                    }
                    throw new IndexOutOfRangeException($"Index cannot be bigger than or equal length({GetLength()})");
                }
                else
                {
                    throw new IndexOutOfRangeException("Index cannot be lower than 0");
                }
            }
        }
    }
}
