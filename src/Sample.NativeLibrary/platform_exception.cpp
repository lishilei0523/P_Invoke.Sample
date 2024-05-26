#include <iostream>
#include <exception>
#include "platform_exception.h"
using namespace std;

void receiveHandledExpcetion()
{
	throw std::bad_exception();
}

void receiveUnhandledExpcetion()
{
	const string text = nullptr;
	std::cout << text << endl;
}
