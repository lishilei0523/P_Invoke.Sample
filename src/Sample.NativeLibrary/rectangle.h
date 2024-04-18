#pragma once
#include "point.h"

struct Rectangle
{
	Rectangle();
	Rectangle(const Point min, const Point max);
	~Rectangle();

	Point Min;
	Point Max;
};
