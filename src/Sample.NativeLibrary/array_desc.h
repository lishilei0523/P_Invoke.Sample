#pragma once
#include <iostream>

struct ArrayDesc
{
	ArrayDesc() = default;
	ArrayDesc(int* numbers, const int length)
	{
		this->Numbers = numbers;
		this->Length = length;
	}
	~ArrayDesc()
	{
		delete[] this->Numbers;
		std::cout << "C++ ArrayDesc析构函数调用" << std::endl;
	}

	int* Numbers;
	int Length;
};
