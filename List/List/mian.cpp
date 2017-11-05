#include<iostream>
#include"ADT.h"
#include"Node.h"

using namespace std;
int main(void)
{
	ADT ad;
	Node *first = ad.create_node();
	Node *second = ad.create_node();
	Node *third = ad.create_node();
	first->next = second;
	second->next = third;
	third->next = nullptr;
	first->data = 1;
	second->data = 2;
	third->data = 3;

	ad.print_list(first);
	return 0;
}
