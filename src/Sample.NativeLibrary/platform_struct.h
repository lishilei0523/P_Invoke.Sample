#pragma once
#define EXPORT extern "C" __declspec(dllexport)
#define CALLING_MODE _cdecl
#include "point.h"
#include "rectangle.h"

EXPORT void CALLING_MODE sendPoint(Point point);
EXPORT void CALLING_MODE sendRectangle(Rectangle rectangle);
EXPORT void CALLING_MODE sendPointPtr(const Point* point);
EXPORT void CALLING_MODE sendRectanglePtr(const Rectangle* rectangle);
EXPORT Point* CALLING_MODE receivePoint();
EXPORT Rectangle* CALLING_MODE receiveRectangle();
EXPORT void CALLING_MODE disposePointPtr(const Point* point);
EXPORT void CALLING_MODE disposeRectanglePtr(const Rectangle* rectangle);
