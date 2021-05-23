#include "ListOfShort.h"

Node* ListOfShort::CreateNode(short number)
{
	Node *newNode = new Node();
	newNode->_number = number;
	newNode->_next = nullptr;
	return newNode;
}

void ListOfShort::AddLast(Node* newNode)
{
    if (newNode != nullptr)
    {
        if (_head == nullptr)
        {
            _head = newNode;
        }
        else
        {
            Node *temp = _head;
            while (temp->_next != nullptr)
                temp = temp->_next;
            temp->_next = newNode;
        }
    }
    else
    {
        throw std::logic_error("Node cannot be null");
    }
}

void ListOfShort::DeleteNode(Node* toDeletion)
{
    if (toDeletion != nullptr)
    {
        Node *temp = _head;
        if (_head == toDeletion)
        {
            _head = toDeletion->_next;
            delete toDeletion;
        }
        else
        {
            while (temp != nullptr && temp->_next != toDeletion)
                temp = temp->_next;
            if (temp != nullptr) {
                temp->_next = toDeletion->_next;
                delete toDeletion;
            }
        }
    }
    else
    {
        throw std::logic_error("Node cannot be null");
    }
}

Node* ListOfShort::Find(short number)
{
    Node *temp = _head;
    while (temp != nullptr && temp->_number != number)
        temp = temp->_next;
    return temp;
}

int ListOfShort::GetLength()
{
    int length = 0;
    Node *temp = _head;
    while (temp != nullptr)
    {
        temp = temp->_next;
        length++;
    }
    return length;
}

int ListOfShort::CountMultiplesOfSeven()
{
    int quantity = 0;
    Node *temp = _head;
    while (temp != nullptr)
    {
        if (temp->_number % 7 == 0)
            quantity++;
        temp = temp->_next;
    }
    return quantity;
}

double ListOfShort::GetAverage()
{
    double average = 0;
    Node *temp = _head;
    while (temp != nullptr)
    {
        average += temp->_number;
        temp = temp->_next;
    }
    if (GetLength() != 0)
        average /= GetLength();
    return average;
}

void ListOfShort::ChangeMoreThanAverageToZero()
{
    double average = GetAverage();
    Node *temp = _head;
    while (temp != nullptr)
    {
        if (temp->_number > average)
            temp->_number = 0;
        temp = temp->_next;
    }
}

short ListOfShort::operator[](int index)
{
    if (index >= 0)
    {
        int currentIndex = 0;
        Node *temp = _head;
        if (temp != nullptr)
        {
            while (temp->_next != nullptr && currentIndex != index)
            {
                currentIndex++;
                temp = temp->_next;
            }
            if (temp != nullptr)
                return temp->_number;
        }
        throw std::out_of_range("Index cannot be bigger than or equal length");
    }
    else
    {
        throw std::out_of_range("Index cannot be lower than 0");
    }
}

ListOfShort::~ListOfShort()
{
    while (_head != nullptr)
        DeleteNode(_head);
}
