#pragma once
#include<iostream>
using namespace std;
#include "Node.h"
class ADT
{
public:
	Node *create_node();//����һ���ڵ�
	int get_length(Node *p);//��ȡlist�ĳ���
	bool insert_data(Node *p, int data, int location); //ָ��λ�ò�������
	bool update_list(Node *p, int data, int location);//��������
	bool delete_data(Node *p, int data, int location);//ɾ������
	bool delete_list(Node *p);//���list
	void print_list(Node *p);//����list�е���������
public:
	ADT();
	~ADT();
};

