#pragma once

struct Point
{
	~Point()
	{
		std::cout << "C++ Point������������" << std::endl;
	}

	int X;
	int Y;
};
