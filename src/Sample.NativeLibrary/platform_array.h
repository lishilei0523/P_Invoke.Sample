#pragma once
#define EXPORT extern "C" __declspec(dllexport)
#define CALLING_MODE _cdecl
#include "point.h"
#include "array_desc.h"

EXPORT void CALLING_MODE sendNumbers(int numbers[], const int length);
EXPORT void CALLING_MODE sendStrings(char* strings[], const int length);
EXPORT void CALLING_MODE sendPoints(Point points[], const int length);
EXPORT ArrayDesc CALLING_MODE receiveArray();
EXPORT ArrayDesc* CALLING_MODE receiveArrayPtr();
EXPORT void CALLING_MODE disposeArrayPtr(const ArrayDesc* arrayDesc);
