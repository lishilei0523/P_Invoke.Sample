#pragma once
#define EXPORT extern "C" __declspec(dllexport)
#define CALLING_MODE _cdecl

//发送部分
EXPORT void CALLING_MODE sendBool(const bool enabled);
EXPORT void CALLING_MODE sendByte(const unsigned char number);
EXPORT void CALLING_MODE sendSByte(const char number);
EXPORT void CALLING_MODE sendShort(const short number);
EXPORT void CALLING_MODE sendUShort(const unsigned short number);
EXPORT void CALLING_MODE sendInt(const int number);
EXPORT void CALLING_MODE sendUInt(const unsigned int number);
EXPORT void CALLING_MODE sendLong(const long long number);
EXPORT void CALLING_MODE sendULong(const unsigned long long number);
EXPORT void CALLING_MODE sendFloat(const float number);
EXPORT void CALLING_MODE sendDouble(const double number);

//接收部分
EXPORT bool CALLING_MODE receiveBool();
EXPORT unsigned char CALLING_MODE receiveByte();
EXPORT char CALLING_MODE receiveSByte();
EXPORT short CALLING_MODE receiveShort();
EXPORT unsigned short CALLING_MODE receiveUShort();
EXPORT int CALLING_MODE receiveInt();
EXPORT unsigned int CALLING_MODE receiveUInt();
EXPORT long long CALLING_MODE receiveLong();
EXPORT unsigned long long CALLING_MODE receiveULong();
EXPORT float CALLING_MODE receiveFloat();
EXPORT double CALLING_MODE receiveDouble();
