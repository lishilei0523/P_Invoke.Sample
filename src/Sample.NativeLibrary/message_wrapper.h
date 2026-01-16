#pragma once
#ifdef _WIN32
#define EXPORT_C extern "C" __declspec(dllexport)
#define CALLING_MODE _cdecl
#elif __linux__
#define EXPORT_C extern "C"
#define CALLING_MODE __attribute__((__cdecl__))
#endif
#include "message.h"

EXPORT_C Message* CALLING_MODE createMessage(const char* title, const char* content);
EXPORT_C void CALLING_MODE send(Message* message, const char* receiver);
EXPORT_C void CALLING_MODE setTitle(Message* message, const char* title);
EXPORT_C void CALLING_MODE setContent(Message* message, const char* content);
EXPORT_C char* CALLING_MODE getTitle(const Message* message);
EXPORT_C char* CALLING_MODE getContent(const Message* message);
EXPORT_C void CALLING_MODE dispose(const Message* message);
