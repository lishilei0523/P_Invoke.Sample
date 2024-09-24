#include <iostream>
#include "platform_string.h"
using namespace std;

void sendString(const char* text)
{
	std::cout << "C++: " << text << endl;
}

char* receiveString()
{
	const string stlStr = "Hello World";

#ifdef _WIN32
    char* text = _strdup(stlStr.c_str());
#elif __linux__
    char* text = (char*)stlStr.c_str();
#endif

	return text;
}
