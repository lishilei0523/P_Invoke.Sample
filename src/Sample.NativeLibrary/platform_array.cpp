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

void sendStrings(char* strings[], const int length)
{
	for (int i = 0; i < length; i++)
	{
		std::cout << strings[i] << endl;
	}
}
