#include <iostream>
#include "platform_primitives.h"
using namespace std;

/*发送部分*/

void sendBool(const bool enabled)
{
	std::cout << "发送bool" << endl;
	std::cout << enabled << endl;
	std::cout << "-----------------------------" << endl;
}

void sendByte(const unsigned char number)
{
	std::cout << "发送byte" << endl;
	std::cout << static_cast<int>(number) << endl;
	std::cout << "-----------------------------" << endl;
}

void sendSByte(const char number)
{
	std::cout << "发送sbyte" << endl;
	std::cout << static_cast<int>(number) << endl;
	std::cout << "-----------------------------" << endl;
}

void sendShort(const short number)
{
	std::cout << "发送short" << endl;
	std::cout << number << endl;
	std::cout << "-----------------------------" << endl;
}

void sendUShort(const unsigned short number)
{
	std::cout << "发送ushort" << endl;
	std::cout << number << endl;
	std::cout << "-----------------------------" << endl;
}

void sendInt(const int number)
{
	std::cout << "发送int" << endl;
	std::cout << number << endl;
	std::cout << "-----------------------------" << endl;
}

void sendUInt(const unsigned int number)
{
	std::cout << "发送uint" << endl;
	std::cout << number << endl;
	std::cout << "-----------------------------" << endl;
}

void sendLong(const long long number)
{
	std::cout << "发送long" << endl;
	std::cout << number << endl;
	std::cout << "-----------------------------" << endl;
}

void sendULong(const unsigned long long number)
{
	std::cout << "发送ulong" << endl;
	std::cout << number << endl;
	std::cout << "-----------------------------" << endl;
}

void sendFloat(const float number)
{
	std::cout << "发送float" << endl;
	std::cout << number << endl;
	std::cout << "-----------------------------" << endl;
}

void sendDouble(const double number)
{
	std::cout << "发送double" << endl;
	std::cout << number << endl;
	std::cout << "-----------------------------" << endl;
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
