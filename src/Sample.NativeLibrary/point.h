#pragma once

struct Point
{
	Point();
	Point(const char* name, const int x, const int y);
	~Point();

	const char* Name;
	int X;
	int Y;
	float Angles[2];
};
