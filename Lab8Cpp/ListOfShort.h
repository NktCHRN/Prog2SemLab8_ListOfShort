#pragma once
#include "Node.h"
#include <exception>
#include <stdexcept>

class ListOfShort {
private:
	Node *_head;                               // head of the list
public:
    static Node* CreateNode(short number);     // create a node
    void AddLast(Node* newNode);               // add a node to the list
    void DeleteNode(Node* toDeletion);         // delete a node
    Node* Find(short number);                  // returns a Node if found, null if not
    int GetLength();                           // length of the list
    int CountMultiplesOfSeven();               // count, how many numbers in array can be divided by 7
    double GetAverage();                       // average of all elements in array
    void ChangeMoreThanAverageToZero();        // all elements that are higher than average are changed to 0
    short operator[](int index);               // indexator
    ~ListOfShort();                            // destroys pointers to all nodes in the list
};