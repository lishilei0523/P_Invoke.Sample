#pragma once
#include <iostream>
#include "point.h"

struct Rectangle
{
	Rectangle()
	{
		std::cout << "***********************************" << std::endl;
		std::cout << "*** C++ Rectangle默认构造函数调用 ***" << std::endl;
		std::cout << "***********************************" << std::endl;
	}
	Rectangle(const Point& min, const Point& max)
	{
		this->Min = min;
		this->Max = max;

		std::cout << "***********************************" << std::endl;
		std::cout << "*** C++ Rectangle有参构造函数调用 ***" << std::endl;
		std::cout << "***********************************" << std::endl;
	}
	~Rectangle()
	{
		std::cout << "********************************" << std::endl;
		std::cout << "*** C++ Rectangle析构函数调用*** " << std::endl;
		std::cout << "********************************" << std::endl;
	}

	Point Min;
	Point Max;
};
