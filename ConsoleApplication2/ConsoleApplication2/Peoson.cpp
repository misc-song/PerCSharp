#include "Peoson.h"
#include<iostream>
using namespace std;
void Peoson::Say(string content)
{
	cout << "今天的天气很好!" << endl;
}

void Peoson::Use(Calculator *cal)
{
	cout << "请输入第一个操作数";
	cin >> cal->num1;
	cout << "请输入操作符";
	cin >> cal->oper;
	cout << "请输入第一个操作数";
	cin >> cal->num2;
	cout << cal->Calculate() << endl;
}

Peoson::Peoson()
{
}


Peoson::~Peoson()
{
}
