#include <iostream>
#include "platform_struct.h"
using namespace std;

void sendPoint(const Point point)
{
	std::cout << "C++ 接收结构体" << endl;

	std::cout << "C++ Point.Name: " << point.Name << endl;
	std::cout << "C++ Point.X: " << point.X << endl;
	std::cout << "C++ Point.Y: " << point.Y << endl;
	for (int i = 0; i < 2; i++)
	{
		std::cout << "C++ Point.Angle[" << i << "]: " << point.Angles[i] << endl;
	}

	std::cout << "------------------------------" << endl;
}

void sendPointPtr(const Point* point)
{
	std::cout << "C++ 接收结构体指针" << endl;

	std::cout << "C++ PointPtr.Name: " << point->Name << endl;
	std::cout << "C++ PointPtr.X: " << point->X << endl;
	std::cout << "C++ PointPtr.Y: " << point->Y << endl;
	for (int i = 0; i < 2; i++)
	{
		std::cout << "C++ Point.Angle[" << i << "]: " << point->Angles[i] << endl;
	}

	std::cout << "------------------------------" << endl;
}

Point receivePoint()
{
	Point point = Point("C++ Point", 55, 66);
	point.Angles[0] = 5.5f;
	point.Angles[1] = 6.6f;

	return point;
}

Point* receivePointPtr()
{
	Point* point = new Point("C++ Point", 77, 88);
	point->Angles[0] = 7.7f;
	point->Angles[1] = 8.8f;

	return point;
}

void disposePointPtr(const Point* point)
{
	delete point;
}
