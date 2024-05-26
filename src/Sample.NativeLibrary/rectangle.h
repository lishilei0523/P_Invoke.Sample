#pragma once
#include <iostream>
#include "point.h"

struct Rectangle
{
	Rectangle()
	{
		std::cout << "C++ RectangleĬ�Ϻ�������" << std::endl;
	}
	Rectangle(const Point& min, const Point& max)
	{
		this->Min = min;
		this->Max = max;
	}
	~Rectangle()
	{
		std::cout << "C++ Rectangle������������" << std::endl;
	}

	Point Min;
	Point Max;
};
