#pragma once

class Node {
private:
	short _number;				// short number
	Node* _next;				// next node
	friend class ListOfShort;	// list should have access to private fields
public:
	short GetNumber();			// get a short number, encapsulated in the node
};