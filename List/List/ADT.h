#pragma once
#include<iostream>
using namespace std;
#include "Node.h"
class ADT
{
public:
	Node *create_node();//创建一个节点
	int get_length(Node *p);//获取list的长度
	bool insert_data(Node *p, int data, int location); //指定位置插入数据
	bool update_list(Node *p, int data, int location);//更新数据
	bool delete_data(Node *p, int data, int location);//删除数据
	bool delete_list(Node *p);//清空list
	void print_list(Node *p);//遍历list中的所有数据
public:
	ADT();
	~ADT();
};

