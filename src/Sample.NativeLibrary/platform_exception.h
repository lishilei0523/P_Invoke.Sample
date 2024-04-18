#pragma once
#define EXPORT extern "C" __declspec(dllexport)
#define CALLING_MODE _cdecl

EXPORT void CALLING_MODE receiveHandledExpcetion();
EXPORT void CALLING_MODE receiveUnhandledExpcetion();
