#pragma once
#ifdef _WIN32
#define EXPORT_C extern "C" __declspec(dllexport)
#define CALLING_MODE _cdecl
#elif __linux__
#define EXPORT_C extern "C"
#define CALLING_MODE __attribute__((__cdecl__))
#endif

//发送部分
EXPORT_C void CALLING_MODE sendBool(bool enabled);
EXPORT_C void CALLING_MODE sendByte(unsigned char number);
EXPORT_C void CALLING_MODE sendSByte(char number);
EXPORT_C void CALLING_MODE sendShort(short number);
EXPORT_C void CALLING_MODE sendUShort(unsigned short number);
EXPORT_C void CALLING_MODE sendInt(int number);
EXPORT_C void CALLING_MODE sendUInt(unsigned int number);
EXPORT_C void CALLING_MODE sendLong(long long number);
EXPORT_C void CALLING_MODE sendULong(unsigned long long number);
EXPORT_C void CALLING_MODE sendFloat(float number);
EXPORT_C void CALLING_MODE sendDouble(double number);

//接收部分
EXPORT_C bool CALLING_MODE receiveBool();
EXPORT_C unsigned char CALLING_MODE receiveByte();
EXPORT_C char CALLING_MODE receiveSByte();
EXPORT_C short CALLING_MODE receiveShort();
EXPORT_C unsigned short CALLING_MODE receiveUShort();
EXPORT_C int CALLING_MODE receiveInt();
EXPORT_C unsigned int CALLING_MODE receiveUInt();
EXPORT_C long long CALLING_MODE receiveLong();
EXPORT_C unsigned long long CALLING_MODE receiveULong();
EXPORT_C float CALLING_MODE receiveFloat();
EXPORT_C double CALLING_MODE receiveDouble();
