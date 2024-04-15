#include <iostream>
#include "platform_string.h"
using namespace std;

void sendString(const char* text)
{
	std::cout << "C++: " << text << endl;
}

const char* receiveString()
{
	const char* text = "Hello World";

	return text;
}
