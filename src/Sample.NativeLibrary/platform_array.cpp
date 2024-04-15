#include <iostream>
#include "platform_array.h"
using namespace std;

void sendNumbers(int numbers[], const int length)
{
	for (int i = 0; i < length; i++)
	{
		std::cout << numbers[i] << endl;
	}
}

int* receiveNumbers()
{
	int* array = static_cast<int*>(malloc(sizeof(int) * 5));
	array[0] = 1;
	array[1] = 2;
	array[2] = 4;
	array[3] = 5;
	array[4] = 6;

	return array;
}

void sendStrings(char* strings[], const int length)
{
	for (int i = 0; i < length; i++)
	{
		std::cout << strings[i] << endl;
	}
}
