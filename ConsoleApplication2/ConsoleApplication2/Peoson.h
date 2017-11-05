#pragma once
#include"Calculator.h"
#include<string>
using namespace std;

class Peoson
{
public:
	int Age;
	string Name;
	char sex;
	void Say(string);
	void Use(Calculator *c);
public:
	Peoson();
	~Peoson();
};

