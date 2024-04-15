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
	char* text = _strdup(stlStr.c_str());
	//char* text = const_cast<char*>("char*: Hello World");

	return text;
}
