#pragma once
#ifdef _WIN32
#define EXPORT_C extern "C" __declspec(dllexport)
#define CALLING_MODE _cdecl
#elif __linux__
#define EXPORT_C extern "C"
#define CALLING_MODE __attribute__((__cdecl__))
#endif
#include "point.h"
#include "array_desc.h"
#include "range_desc.h"
#include "matrix_desc.h"
#include "matrix4x4.h"

EXPORT_C void CALLING_MODE sendNumbers(int numbers[], int length);
EXPORT_C void CALLING_MODE sendStrings(char* strings[], int length);
EXPORT_C void CALLING_MODE sendPoints(Point points[], int length);
EXPORT_C ArrayDesc* CALLING_MODE receiveArray();
EXPORT_C ArrayDesc** CALLING_MODE receiveArrayGroup(int& groupCount);
EXPORT_C RangeDesc* CALLING_MODE receiveRange();
EXPORT_C MatrixDesc* CALLING_MODE receiveMatrix();
EXPORT_C Matrix4x4* CALLING_MODE receiveMatrix4x4();
EXPORT_C void CALLING_MODE disposeArray(const ArrayDesc* pointer);
EXPORT_C void CALLING_MODE disposeArrayGroup(const ArrayDesc** pointer, int groupCount);
EXPORT_C void CALLING_MODE disposeRange(const RangeDesc* pointer);
EXPORT_C void CALLING_MODE disposeMatrix(const MatrixDesc* pointer);
EXPORT_C void CALLING_MODE disposeMatrix4x4(const Matrix4x4* pointer);
