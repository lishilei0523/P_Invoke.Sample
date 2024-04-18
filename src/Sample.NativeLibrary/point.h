#pragma once

struct Point
{
	Point();
	Point(const char* name, const int x, const int y);
	~Point();

	const char* Name;
	int X;
	int Y;
	const char* Titles[2];
	float Angles[2];
};
