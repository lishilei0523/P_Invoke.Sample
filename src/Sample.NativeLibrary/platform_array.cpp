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
