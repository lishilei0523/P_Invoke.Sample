#pragma once

struct Point
{
	~Point()
	{
		std::cout << "C++ Point析构函数调用" << std::endl;
	}

	int X;
	int Y;
};
