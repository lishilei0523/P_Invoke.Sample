#pragma once
#define EXPORT extern "C" __declspec(dllexport)
#define CALLING_MODE __stdcall

EXPORT int CALLING_MODE greet(const char* text);
EXPORT int CALLING_MODE sum(const int a, const int b);
EXPORT int CALLING_MODE minus(const int a, const int b);
