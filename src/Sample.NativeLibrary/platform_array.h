#pragma once
#define EXPORT extern "C" __declspec(dllexport)
#define CALLING_MODE _cdecl
#include "point.h"
#include "array_desc.h"
#include "matrix_desc.h"
#include "range_desc.h"

EXPORT void CALLING_MODE sendNumbers(int numbers[], int length);
EXPORT void CALLING_MODE sendStrings(char* strings[], int length);
EXPORT void CALLING_MODE sendPoints(Point points[], int length);
EXPORT ArrayDesc* CALLING_MODE receiveArray();
EXPORT MatrixDesc* CALLING_MODE receiveMatrix();
EXPORT RangeDesc* CALLING_MODE receiveRange();
EXPORT void CALLING_MODE disposeArray(const ArrayDesc* pointer);
EXPORT void CALLING_MODE disposeMatrix(const MatrixDesc* pointer);
EXPORT void CALLING_MODE disposeRange(const RangeDesc* pointer);
