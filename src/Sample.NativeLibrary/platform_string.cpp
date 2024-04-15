#include <iostream>
#include "platform_string.h"
using namespace std;

void sendString(const char* text)
{
	std::cout << "C++: " << text << endl;
}

char* receiveString()
{
	char* text = const_cast<char*>("Hello World");

	return text;
}
