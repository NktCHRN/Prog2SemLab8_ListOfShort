#pragma once
#include <exception>
#include <stdexcept>

class ListOfShort {
private:
    struct Node {
        short _number;				           // short number
        Node* _next;				           // next node
    };
	Node *_head;                               // head of the list
    Node* CreateNode(short number);            // create a node
    void DeleteNode(Node* toDeletion);         // delete a node
public:
    void AddLast(short number);                // add a node to the list
    int GetLength();                           // length of the list
    int CountMultiplesOfSeven();               // count, how many numbers in array can be divided by 7
    double GetAverage();                       // average of all elements in array
    void ChangeMoreThanAverageToZero();        // all elements that are higher than average are changed to 0
    short operator[](int index);               // indexator
    ~ListOfShort();                            // destroys pointers to all nodes in the list
};