#pragma once
#include <iostream>

struct Point
{
	Point()
	{
		std::cout << "********************************" << std::endl;
		std::cout << "*** C++ Point默认构造函数调用 ***" << std::endl;
		std::cout << "********************************" << std::endl;
	}
	Point(const char* name, const int& x, const int& y)
	{
		this->Name = name;
		this->X = x;
		this->Y = y;

		std::cout << "********************************" << std::endl;
		std::cout << "*** C++ Point有参构造函数调用 ***" << std::endl;
		std::cout << "********************************" << std::endl;
	}
	~Point()
	{
		std::cout << "*****************************" << std::endl;
		std::cout << "*** C++ Point析构函数调用 ***" << std::endl;
		std::cout << "*****************************" << std::endl;
	}

	const char* Name;
	int X;
	int Y;
	const char* Titles[2];
	float Angles[2];
};
