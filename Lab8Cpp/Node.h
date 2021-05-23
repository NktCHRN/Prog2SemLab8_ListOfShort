#pragma once

class Node {
private:
	short _number;
	Node* _next;
	friend class ListOfShort;
public:
	short GetNumber();
};