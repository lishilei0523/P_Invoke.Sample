#include <cstring>
#include "platform.h"

int greet(const char* text)
{
	return static_cast<int>(strlen(text));
}

int sum(const int a, const int b)
{
	return a + b;
}

int minus(const int a, const int b)
{
	return a - b;
}
