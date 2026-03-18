#include <iostream>
#include <format>
#include "platform_string.h"
using namespace std;

void sendString(const char* text)
{
	std::cout << "C++: " << text << endl;
}

void sendStringBuilder(char* textBuilder)
{
	string text = "F:\\Text.txt";
	strcpy_s(textBuilder, text.length() + 1, text.c_str());

	std::cout << std::format("C++: {}", textBuilder) << endl;
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
