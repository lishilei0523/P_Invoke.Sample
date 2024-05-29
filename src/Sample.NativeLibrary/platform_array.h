#pragma once
#define EXPORT extern "C" __declspec(dllexport)
#define CALLING_MODE _cdecl
#include "point.h"
#include "array_desc.h"
#include "range_desc.h"
#include "matrix_desc.h"
#include "matrix4x4.h"

EXPORT void CALLING_MODE sendNumbers(int numbers[], int length);
EXPORT void CALLING_MODE sendStrings(char* strings[], int length);
EXPORT void CALLING_MODE sendPoints(Point points[], int length);
EXPORT ArrayDesc* CALLING_MODE receiveArray();
EXPORT ArrayDesc** CALLING_MODE receiveArrayGroup(int& groupCount);
EXPORT RangeDesc* CALLING_MODE receiveRange();
EXPORT MatrixDesc* CALLING_MODE receiveMatrix();
EXPORT Matrix4x4* CALLING_MODE receiveMatrix4x4();
EXPORT void CALLING_MODE disposeArray(const ArrayDesc* pointer);
EXPORT void CALLING_MODE disposeArrayGroup(const ArrayDesc** pointer, int groupCount);
EXPORT void CALLING_MODE disposeRange(const RangeDesc* pointer);
EXPORT void CALLING_MODE disposeMatrix(const MatrixDesc* pointer);
EXPORT void CALLING_MODE disposeMatrix4x4(const Matrix4x4* pointer);
