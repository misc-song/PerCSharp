#pragma once
class Calculator
{
public:
	double num1;
	double num2;
	char oper;
	double res;
	double Calculate(double, double, char);
	double Calculate();
public:
	Calculator();
	~Calculator();
};

