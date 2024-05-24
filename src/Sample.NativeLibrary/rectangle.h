#pragma once
#include <iostream>
#include "point.h"

struct Rectangle
{
	Rectangle() = default;
	Rectangle(const Point min, const Point max)
	{
		this->Min = min;
		this->Max = max;
	}
	~Rectangle()
	{
		std::cout << "C++ Rectangle析构函数调用" << std::endl;
	}

	Point Min;
	Point Max;
};
