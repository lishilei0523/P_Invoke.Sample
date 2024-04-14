#include <cstring>
#include "platform.h"

int greet(const char* text)
{
	return static_cast<int>(strlen(text));
}

int sum(int a, int b)
{
	return a + b;
}

int minus(int a, int b)
{
	return a - b;
}
