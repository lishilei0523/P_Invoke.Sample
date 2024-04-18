#include <iostream>
#include <string>
#include <exception>
#include "platform_exception.h"
using namespace std;

void receiveHandledExpcetion()
{
	throw std::bad_exception();
}

void receiveUnhandledExpcetion()
{
	const std::string text = nullptr;
	std::cout << text << endl;
}
