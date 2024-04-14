#pragma once
#define EXTERN_C extern "C" __declspec(dllexport)

EXTERN_C int greet(const char* text);
EXTERN_C int sum(int a, int b);
EXTERN_C int minus(int a, int b);
