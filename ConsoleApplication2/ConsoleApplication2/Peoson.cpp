#include "Peoson.h"
#include<iostream>
using namespace std;
void Peoson::Say(string content)
{
	cout << "����������ܺ�!" << endl;
}

void Peoson::Use(Calculator *cal)
{
	cout << "�������һ��������";
	cin >> cal->num1;
	cout << "�����������";
	cin >> cal->oper;
	cout << "�������һ��������";
	cin >> cal->num2;
	cout << cal->Calculate() << endl;
}

Peoson::Peoson()
{
}


Peoson::~Peoson()
{
}
