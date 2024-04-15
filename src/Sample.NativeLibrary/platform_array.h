#pragma once
#define EXPORT extern "C" __declspec(dllexport)
#define CALLING_MODE _cdecl

EXPORT void CALLING_MODE sendNumbers(int numbers[], int length);
EXPORT void CALLING_MODE sendStrings(char* strings[], int length);
