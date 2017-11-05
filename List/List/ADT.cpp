#include "ADT.h"

Node* ADT::create_node()//����һ���ڵ�
{
	return new Node();
}
int ADT::get_length(Node *p)//��ȡlist�ĳ���
{
	int count = 0;
	while (p)
	{
		p = p->next;
		count++;
	}
	return count;
}
bool ADT::insert_data(Node *p, int data, int location) //ָ��λ�ò�������
{
	while (p)
	{
		p = p->next;
	}
	if (nullptr == p)
	{
		cout << "�����λ�ó���" << endl;
		return false;
	}
	Node *temp = create_node();
	temp->data = data;
	temp->next = p->next;
	p->next = temp;
	return true;

}
bool ADT::update_list(Node *p, int data, int location)//��������
{
	while (p && location--)
	{
		p = p->next;
	}
	if (nullptr == p)
	{
		cout << "�����λ�ò���ȷ" << endl;
		return false;
	}
	p->data = data;
	return true;
}

bool ADT::delete_data(Node *p, int data, int location)//ɾ������
{
	while (p && location--)
	{
		p = p->next;
	}
	if (nullptr == p)
	{
		cout << "�����λ�ò���ȷ" << endl;
		return false;
	}
	Node * temp = p->next;
	p->next = p->next->next;
	delete(p);
	return true;

}
bool ADT::delete_list(Node *p)//���list
{
	p->next = nullptr;
	return true;
}
void ADT::print_list(Node *p)//�������е�����
{
	while (p)
	{
		cout << "������:" << p->data << endl; 
		p = p->next;
	}
}


ADT::ADT()
{
}


ADT::~ADT()
{
}
