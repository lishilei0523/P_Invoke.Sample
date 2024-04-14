#pragma once
#define EXTERN_C extern "C" __declspec(dllexport)
#define CALLING_MODE __stdcall

EXTERN_C int CALLING_MODE greet(const char* text);
EXTERN_C int CALLING_MODE sum(const int a, const int b);
EXTERN_C int CALLING_MODE minus(const int a, const int b);
