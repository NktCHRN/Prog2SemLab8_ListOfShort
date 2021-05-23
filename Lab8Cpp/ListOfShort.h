#pragma once
#include "Node.h"
#include <exception>
#include <stdexcept>

class ListOfShort {
private:
	Node *_head;
public:
    static Node* CreateNode(short number);
    void AddLast(Node* newNode);
    void DeleteNode(Node* toDeletion);
    Node* Find(short number);
    int GetLength();
    int CountMultiplesOfSeven();
    double GetAverage();
    void ChangeMoreThanAverageToZero();
    short operator[](int index);
    ~ListOfShort();
};