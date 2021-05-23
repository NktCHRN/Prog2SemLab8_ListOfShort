using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfShortLib
{
    public class ListOfShort
    {
        private Node _head;
        public static Node CreateNode(short number)
        {
            Node newNode = new Node
            {
                Number = number,
                Next = null
            };
            return newNode;
        }
        public void AddLast(Node newNode)
        {
            if (newNode != null)
            {
                if (_head == null)
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
        public void DeleteNode(Node toDeletion)
        {
            if (toDeletion != null)
            {
                Node temp = _head;
                if (_head == toDeletion)
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
        public Node Find(short number)
        {
            Node temp = _head;
            while (temp != null && temp.Number != number)
                temp = temp.Next;
            return temp;
        }
        public int GetLength()
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
        public int CountMultiplesOfSeven()
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
        public double GetAverage()
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
        public void ChangeMoreThanAverageToZero()
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
        public short this[int index]
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
