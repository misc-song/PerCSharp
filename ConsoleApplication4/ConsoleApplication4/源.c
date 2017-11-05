#include<stdio.h>
void main(void)
{
	//跳出循环基本一样
	for (int i = 0; i < 10; i++)
	{
		if (i == 5)
		{
			break;
		}
		else
		{
			printf("输出是%d\n", i);

		}
	}
	//C和上面的Java结果基本相同在switch...case...中没有break程序不会报错 会一直运行下去
	int num = 1;
	switch (num)
	{
	case 1:
		printf("输出的结果是1\n");
	case 2:
		printf("输出的结果是2\n");
	case 3:
		printf("输出的结果是3\n");
	case 4:
		printf("输出的结果是4\n");
	case 5:
		printf("输出的结果是5\n");
	default:
		printf("没有输出结果\n");
	}
	int number = 1;
	switch (number)
	{
	case 1:
		printf("输出的结果是1\n");
		break;
	case 2:
		printf("输出的结果是2\n");
		break;
	case 3:
		printf("输出的结果是3\n");
		break;
	case 4:
		printf("输出的结果是4\n");
	case 5:
		printf("输出的结果是5");
		break;
	default:
		printf("没有输出结果\n");
		break;
	}
}