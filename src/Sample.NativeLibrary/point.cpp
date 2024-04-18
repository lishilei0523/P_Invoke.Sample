#include <iostream>
#include "point.h"
using namespace std;

Point::Point() = default;

Point::Point(const char* name, const int x, const int y)
	:Point()
{
	this->Name = name;
	this->X = x;
	this->Y = y;
}

Point::~Point()
{
	std::cout << "C++ Point析构函数调用" << endl;
}
