#pragma once

struct RangeDesc
{
	RangeDesc() = default;
	~RangeDesc()
	{
		std::cout << "C++ RangeDesc������������" << std::endl;
	}

	float Histogram[33];
};
