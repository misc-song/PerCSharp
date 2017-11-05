#include "ADT.h"

Node* ADT::create_node()//创建一个节点
{
	return new Node();
}
int ADT::get_length(Node *p)//获取list的长度
{
	int count = 0;
	while (p)
	{
		p = p->next;
		count++;
	}
	return count;
}
bool ADT::insert_data(Node *p, int data, int location) //指定位置插入数据
{
	while (p)
	{
		p = p->next;
	}
	if (nullptr == p)
	{
		cout << "插入的位置出错" << endl;
		return false;
	}
	Node *temp = create_node();
	temp->data = data;
	temp->next = p->next;
	p->next = temp;
	return true;

}
bool ADT::update_list(Node *p, int data, int location)//更新数据
{
	while (p && location--)
	{
		p = p->next;
	}
	if (nullptr == p)
	{
		cout << "插入的位置不正确" << endl;
		return false;
	}
	p->data = data;
	return true;
}

bool ADT::delete_data(Node *p, int data, int location)//删除数据
{
	while (p && location--)
	{
		p = p->next;
	}
	if (nullptr == p)
	{
		cout << "插入的位置不正确" << endl;
		return false;
	}
	Node * temp = p->next;
	p->next = p->next->next;
	delete(p);
	return true;

}
bool ADT::delete_list(Node *p)//清空list
{
	p->next = nullptr;
	return true;
}
void ADT::print_list(Node *p)//遍历所有的数据
{
	while (p)
	{
		cout << "数据是:" << p->data << endl; 
		p = p->next;
	}
}


ADT::ADT()
{
}


ADT::~ADT()
{
}
