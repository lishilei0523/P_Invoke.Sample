#pragma once
#include <iostream>
#include "point.h"

struct Rectangle
{
	Rectangle()
	{
		std::cout << "***********************************" << std::endl;
		std::cout << "*** C++ RectangleĬ�Ϲ��캯������ ***" << std::endl;
		std::cout << "***********************************" << std::endl;
	}
	Rectangle(const Point& min, const Point& max)
	{
		this->Min = min;
		this->Max = max;

		std::cout << "***********************************" << std::endl;
		std::cout << "*** C++ Rectangle�вι��캯������ ***" << std::endl;
		std::cout << "***********************************" << std::endl;
	}
	~Rectangle()
	{
		std::cout << "********************************" << std::endl;
		std::cout << "*** C++ Rectangle������������*** " << std::endl;
		std::cout << "********************************" << std::endl;
	}

	Point Min;
	Point Max;
};
