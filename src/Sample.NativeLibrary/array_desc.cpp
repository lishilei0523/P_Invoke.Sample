#include <iostream>
#include "array_desc.h"
using namespace std;

ArrayDesc::ArrayDesc() = default;

ArrayDesc::ArrayDesc(const int* numbers, const int length)
{
	this->Numbers = numbers;
	this->Length = length;
}

ArrayDesc::~ArrayDesc()
{
	delete[] this->Numbers;
	std::cout << "C++ ArrayDesc析构函数调用" << std::endl;
}
