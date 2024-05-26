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
		std::cout << "C++ Point.Titles[" << i << "]: " << point.Titles[i] << endl;
		std::cout << "C++ Point.Angles[" << i << "]: " << point.Angles[i] << endl;
	}

	std::cout << "------------------------------" << endl;
}

void sendRectangle(const Rectangle rectangle)
{
	std::cout << "C++ 接收嵌套结构体" << endl;

	const Point* point1 = &rectangle.Min;
	const Point* point2 = &rectangle.Max;

	std::cout << "C++ PointMin.Name: " << point1->Name << endl;
	std::cout << "C++ PointMin.X: " << point1->X << endl;
	std::cout << "C++ PointMin.Y: " << point1->Y << endl;
	for (int i = 0; i < 2; i++)
	{
		std::cout << "C++ PointMin.Titles[" << i << "]: " << point1->Titles[i] << endl;
		std::cout << "C++ PointMin.Angles[" << i << "]: " << point1->Angles[i] << endl;
	}
	std::cout << "C++ PointMax.Name: " << point2->Name << endl;
	std::cout << "C++ PointMax.X: " << point2->X << endl;
	std::cout << "C++ PointMax.Y: " << point2->Y << endl;
	for (int i = 0; i < 2; i++)
	{
		std::cout << "C++ PointMax.Titles[" << i << "]: " << point2->Titles[i] << endl;
		std::cout << "C++ PointMax.Angles[" << i << "]: " << point2->Angles[i] << endl;
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
		std::cout << "C++ Point.Titles[" << i << "]: " << point->Titles[i] << endl;
		std::cout << "C++ Point.Angles[" << i << "]: " << point->Angles[i] << endl;
	}

	std::cout << "------------------------------" << endl;
}

void sendRectanglePtr(const Rectangle* rectangle)
{
	std::cout << "C++ 接收嵌套结构体指针" << endl;

	const Point* point1 = &rectangle->Min;
	const Point* point2 = &rectangle->Max;

	std::cout << "C++ PointMin.Name: " << point1->Name << endl;
	std::cout << "C++ PointMin.X: " << point1->X << endl;
	std::cout << "C++ PointMin.Y: " << point1->Y << endl;
	for (int i = 0; i < 2; i++)
	{
		std::cout << "C++ PointMin.Titles[" << i << "]: " << point1->Titles[i] << endl;
		std::cout << "C++ PointMin.Angles[" << i << "]: " << point1->Angles[i] << endl;
	}
	std::cout << "C++ PointMax.Name: " << point2->Name << endl;
	std::cout << "C++ PointMax.X: " << point2->X << endl;
	std::cout << "C++ PointMax.Y: " << point2->Y << endl;
	for (int i = 0; i < 2; i++)
	{
		std::cout << "C++ PointMax.Titles[" << i << "]: " << point2->Titles[i] << endl;
		std::cout << "C++ PointMax.Angles[" << i << "]: " << point2->Angles[i] << endl;
	}

	std::cout << "------------------------------" << endl;
}

Point* receivePoint()
{
	Point* point = new Point("C++ Point", 77, 88);
	point->Titles[0] = "Title: 7.7f";
	point->Titles[1] = "Title: 8.8f";
	point->Angles[0] = 7.7f;
	point->Angles[1] = 8.8f;

	return point;
}

Rectangle* receiveRectangle()
{
	Point point1 = Point("C++ Point Min", 11, 12);
	point1.Titles[0] = "Title: 1.1f";
	point1.Titles[1] = "Title: 1.2f";
	point1.Angles[0] = 1.1f;
	point1.Angles[1] = 1.2f;
	Point point2 = Point("C++ Point Max", 21, 22);
	point2.Titles[0] = "Title: 2.1f";
	point2.Titles[1] = "Title: 2.2f";
	point2.Angles[0] = 2.1f;
	point2.Angles[1] = 2.2f;
	Rectangle* rectangle = new Rectangle(point1, point2);

	return rectangle;
}

void disposePoint(const Point* pointer)
{
	delete pointer;
}

void disposeRectangle(const Rectangle* pointer)
{
	delete pointer;
}
