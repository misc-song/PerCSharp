#include<stdio.h>
void main(void)
{
	//����ѭ������һ��
	for (int i = 0; i < 10; i++)
	{
		if (i == 5)
		{
			break;
		}
		else
		{
			printf("�����%d\n", i);

		}
	}
	//C�������Java���������ͬ��switch...case...��û��break���򲻻ᱨ�� ��һֱ������ȥ
	int num = 1;
	switch (num)
	{
	case 1:
		printf("����Ľ����1\n");
	case 2:
		printf("����Ľ����2\n");
	case 3:
		printf("����Ľ����3\n");
	case 4:
		printf("����Ľ����4\n");
	case 5:
		printf("����Ľ����5\n");
	default:
		printf("û��������\n");
	}
	int number = 1;
	switch (number)
	{
	case 1:
		printf("����Ľ����1\n");
		break;
	case 2:
		printf("����Ľ����2\n");
		break;
	case 3:
		printf("����Ľ����3\n");
		break;
	case 4:
		printf("����Ľ����4\n");
	case 5:
		printf("����Ľ����5");
		break;
	default:
		printf("û��������\n");
		break;
	}
}