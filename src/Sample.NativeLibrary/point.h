#pragma once
#include <iostream>

struct Point
{
	Point() = default;
	Point(const char* name, const int x, const int y)
	{
		this->Name = name;
		this->X = x;
		this->Y = y;
	}
	~Point()
	{
		std::cout << "C++ Point析构函数调用" << std::endl;
	}

	const char* Name;
	int X;
	int Y;
	const char* Titles[2];
	float Angles[2];
};
