#pragma once
#define EXPORT extern "C" __declspec(dllexport)
#define CALLING_MODE _cdecl

EXPORT void CALLING_MODE sendString(const char* text);
EXPORT char* CALLING_MODE receiveString();
