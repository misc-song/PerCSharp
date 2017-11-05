#include<iostream>
#include"Peoson.h"
#include"Calculator.h"
using namespace std;
void main()
{
	//cout << "happy" << endl;
	//Peoson *p = new Peoson();
	//string sayContent = "I am very happy";
	//p->Say(sayContent);


	//Calculator *c = new Calculator();
	//c->num1 = 15;
	//c->num2 = 16;
	//c->oper = '+';
	//cout<<c->Calculate();


	Peoson *p = new Peoson();
	Calculator *c = new Calculator();
	p->Use(c);



	cin.get();
}