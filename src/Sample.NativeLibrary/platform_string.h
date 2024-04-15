#pragma once
#define EXPORT extern "C" __declspec(dllexport)
#define CALLING_MODE __stdcall

EXPORT void CALLING_MODE sendString(const char* text);
EXPORT const char* CALLING_MODE receiveString();
