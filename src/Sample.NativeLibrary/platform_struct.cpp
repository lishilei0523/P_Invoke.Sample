#include <iostream>
#include "platform_struct.h"
using namespace std;

void sendPoint(const Point point)
{
	std::cout << "C++ Point.X: " << point.X << endl;
	std::cout << "C++ Point.Y: " << point.Y << endl;
}

void sendPointPtr(const Point* point)
{
	std::cout << "C++ PointPtr.X: " << point->X << endl;
	std::cout << "C++ PointPtr.Y: " << point->Y << endl;
}

Point receivePoint()
{
	Point point;
	point.X = 10;
	point.Y = 100;

	return point;
}

Point* receivePointPtr()
{
	Point* point = new Point();
	point->X = 10;
	point->Y = 100;

	return point;
}

void disposePointPtr(const Point* point)
{
	delete point;
}
