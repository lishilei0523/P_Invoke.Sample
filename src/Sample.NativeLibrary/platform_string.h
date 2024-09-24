#pragma once
#ifdef _WIN32
#define EXPORT_C extern "C" __declspec(dllexport)
#define CALLING_MODE _cdecl
#elif __linux__
#define EXPORT_C extern "C"
#define CALLING_MODE __attribute__((__cdecl__))
#endif

EXPORT_C void CALLING_MODE sendString(const char* text);
EXPORT_C char* CALLING_MODE receiveString();
