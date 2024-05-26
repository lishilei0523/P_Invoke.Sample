#include <iostream>
#include <format>
#include "platform_primitives.h"
using namespace std;

/*发送部分*/

void sendBool(const bool enabled)
{
	std::cout << std::format("C++接收bool: {} ", enabled) << endl;
}

void sendByte(const unsigned char number)
{
	std::cout << std::format("C++接收byte: {}", static_cast<int>(number)) << endl;
}

void sendSByte(const char number)
{
	std::cout << std::format("C++接收sbyte: {}", static_cast<int>(number)) << endl;
}

void sendShort(const short number)
{
	std::cout << std::format("C++接收short: {}", number) << endl;
}

void sendUShort(const unsigned short number)
{
	std::cout << std::format("C++接收ushort: {}", number) << endl;
}

void sendInt(const int number)
{
	std::cout << std::format("C++接收int: {}", number) << endl;
}

void sendUInt(const unsigned int number)
{
	std::cout << std::format("C++接收uint: {}", number) << endl;
}

void sendLong(const long long number)
{
	std::cout << std::format("C++接收long: {}", number) << endl;
}

void sendULong(const unsigned long long number)
{
	std::cout << std::format("C++接收ulong: {}", number) << endl;
}

void sendFloat(const float number)
{
	std::cout << std::format("C++接收float: {}", number) << endl;
}

void sendDouble(const double number)
{
	std::cout << std::format("C++接收double: {}", number) << endl;
}

/*接收部分*/

bool receiveBool()
{
	return true;
}

unsigned char receiveByte()
{
	return 255;
}

char receiveSByte()
{
	return 127;
}

short receiveShort()
{
	return 32000;
}

unsigned short receiveUShort()
{
	return 65500;
}

int receiveInt()
{
	return 2165500;
}

unsigned int receiveUInt()
{
	return 4165500;
}

long long receiveLong()
{
	return 84165500;
}

unsigned long long receiveULong()
{
	return 164165500;
}

float receiveFloat()
{
	return 0.5f;
}

double receiveDouble()
{
	return 3.14;
}
