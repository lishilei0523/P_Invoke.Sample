#pragma once
#define EXPORT extern "C" __declspec(dllexport)
#define CALLING_MODE _cdecl
#include "point.h"

EXPORT void CALLING_MODE sendPoint(const Point point);
EXPORT void CALLING_MODE sendPointPtr(const Point* point);
EXPORT Point CALLING_MODE receivePoint();
EXPORT Point* CALLING_MODE receivePointPtr();
EXPORT void CALLING_MODE disposePointPtr(const Point* point);
