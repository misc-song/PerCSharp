#include<iostream>
using namespace std;
void main(void)
{
	for (int i = 0; i < 10; i++)
	{
		if (i == 5)
		{
			break;
		}
		else
		{
			cout << "结果是:" << i << endl;

		}
	}

	int num = 1;
	switch (num)
	{
	case 1:
		cout << "输出的结果是1"<< endl;
	case 2:
		cout << "输出的结果是2" << endl;
	case 3:
		cout << "输出的结果是3" << endl;
	case 4:
		cout << "输出的结果是4" << endl;
	case 5:
		cout << "输出的结果是5" << endl;
	default:
		cout << "没有输出结果" << endl;
	}
	int number = 1;
	switch (number)
	{
	case 1:
		cout << "输出的结果是1" << endl;
		break;
	case 2:
		cout << "输出的结果是2" << endl;
		break;
	case 3:
		cout << "输出的结果是3" << endl;
		break;
	case 4:
		cout << "输出的结果是4" << endl;
		break;
	case 5:
		cout << "输出的结果是5" << endl;
		break;
	default:
		cout << "没有输出结果" << endl;
		break;
	}
}