#include "Calculator.h"

double Calculator::Calculate(double num1, double num2, char oper)
{
	if (oper == '+')
	{
		res = num1 + num2;
		return res;
	}
	if (oper == '-')
	{
		res = num1 - num2;
		return res;
	}
	if (oper == '*')
	{
		res = num1 * num2;
		return res;
	}
	if (oper == '/')
	{
		res = num1 / num2;
		return res;
	}

}

double Calculator::Calculate()
{
	/*this->res = this->num1 + this->num2;*/
	
	if (this->oper == '+')
	{
		this->res = this->num1 + this->num2;
		return res;
	}
	if (this->oper == '-')
	{
		this->res = this->num1 - this->num2;
		return res;
	}
	if (this->oper == '*')
	{
		this->res = this->num1 * this->num2;
		return res;
	}
	if (this->oper == '/')
	{
		this->res = this->num1 / this->num2;
		return res;
	}

	return res;

}
//double Calculator::Calculate()
//{
//	this->res = this->num1 + this->num2;
//	return res;
//}
Calculator::Calculator()
{
}


Calculator::~Calculator()
{
}
