#pragma once

struct RangeDesc
{
	RangeDesc() = default;
	~RangeDesc()
	{
		std::cout << "C++ RangeDesc析构函数调用" << std::endl;
	}

	float Histogram[33];
};
