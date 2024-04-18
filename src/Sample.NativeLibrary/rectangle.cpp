#include <iostream>
#include "rectangle.h"
using namespace std;

Rectangle::Rectangle() = default;

Rectangle::Rectangle(const Point min, const Point max)
{
	this->Min = min;
	this->Max = max;
}

Rectangle::~Rectangle()
{
	std::cout << "C++ Rectangle析构函数调用" << std::endl;
}
