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
			cout << "�����:" << i << endl;

		}
	}

	int num = 1;
	switch (num)
	{
	case 1:
		cout << "����Ľ����1"<< endl;
	case 2:
		cout << "����Ľ����2" << endl;
	case 3:
		cout << "����Ľ����3" << endl;
	case 4:
		cout << "����Ľ����4" << endl;
	case 5:
		cout << "����Ľ����5" << endl;
	default:
		cout << "û��������" << endl;
	}
	int number = 1;
	switch (number)
	{
	case 1:
		cout << "����Ľ����1" << endl;
		break;
	case 2:
		cout << "����Ľ����2" << endl;
		break;
	case 3:
		cout << "����Ľ����3" << endl;
		break;
	case 4:
		cout << "����Ľ����4" << endl;
		break;
	case 5:
		cout << "����Ľ����5" << endl;
		break;
	default:
		cout << "û��������" << endl;
		break;
	}
}