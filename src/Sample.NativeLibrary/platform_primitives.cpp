#include <iostream>
#include <format>
#include "platform_primitives.h"
using namespace std;

/*���Ͳ���*/

void sendBool(const bool enabled)
{
	std::cout << std::format("C++����bool: {} ", enabled) << endl;
}

void sendByte(const unsigned char number)
{
	std::cout << std::format("C++����byte: {}", static_cast<int>(number)) << endl;
}

void sendSByte(const char number)
{
	std::cout << std::format("C++����sbyte: {}", static_cast<int>(number)) << endl;
}

void sendShort(const short number)
{
	std::cout << std::format("C++����short: {}", number) << endl;
}

void sendUShort(const unsigned short number)
{
	std::cout << std::format("C++����ushort: {}", number) << endl;
}

void sendInt(const int number)
{
	std::cout << std::format("C++����int: {}", number) << endl;
}

void sendUInt(const unsigned int number)
{
	std::cout << std::format("C++����uint: {}", number) << endl;
}

void sendLong(const long long number)
{
	std::cout << std::format("C++����long: {}", number) << endl;
}

void sendULong(const unsigned long long number)
{
	std::cout << std::format("C++����ulong: {}", number) << endl;
}

void sendFloat(const float number)
{
	std::cout << std::format("C++����float: {}", number) << endl;
}

void sendDouble(const double number)
{
	std::cout << std::format("C++����double: {}", number) << endl;
}

/*���ղ���*/

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
