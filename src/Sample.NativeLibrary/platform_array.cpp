#include <iostream>
#include "platform_array.h"

#include <vector>
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

void sendPoints(Point points[], const int length)
{
	for (int i = 0; i < length; i++)
	{
		std::cout << "Point.Name: " << points[i].Name << endl;
		std::cout << "Point.X: " << points[i].X << endl;
		std::cout << "Point.Y: " << points[i].Y << endl;

		const Point point = points[i];
		for (int j = 0; j < 2; j++)
		{
			std::cout << "C++ Point.Titles[" << j << "]: " << point.Titles[j] << endl;
			std::cout << "C++ Point.Angles[" << j << "]: " << point.Angles[j] << endl;
		}
	}
}

ArrayDesc receiveArray()
{
	vector<int> numbers;
	for (int i = 0; i < 10; i++)
	{
		numbers.push_back(i);
	}

	const int length = (int)numbers.size();
	int* numbersPtr = new int[length];
	memcpy(numbersPtr, numbers.data(), length * sizeof(int));
	ArrayDesc arrayDesc = ArrayDesc(numbersPtr, length);

	for (int i = 0; i < arrayDesc.Length; i++)
	{
		std::cout << "C++ Array[" << i << "]: " << numbersPtr[i] << endl;
	}

	return arrayDesc;
}

ArrayDesc* receiveArrayPtr()
{
	vector<int> numbers;
	for (int i = 0; i < 10; i++)
	{
		numbers.push_back(i);
	}

	const int length = (int)numbers.size();
	int* numbersPtr = new int[length];
	memcpy(numbersPtr, numbers.data(), length * sizeof(int));
	ArrayDesc* arrayDesc = new ArrayDesc(numbersPtr, length);

	for (int i = 0; i < arrayDesc->Length; i++)
	{
		std::cout << "C++ Array[" << i << "]: " << numbersPtr[i] << endl;
	}

	return arrayDesc;
}

void disposeArrayPtr(const ArrayDesc* arrayDesc)
{
	delete arrayDesc;
}
