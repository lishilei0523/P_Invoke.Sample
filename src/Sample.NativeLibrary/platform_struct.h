#pragma once
#define EXPORT extern "C" __declspec(dllexport)
#define CALLING_MODE _cdecl
#include "point.h"
#include "rectangle.h"

EXPORT void CALLING_MODE sendPoint(const Point point);
EXPORT void CALLING_MODE sendPointRef(const Point& point);
EXPORT void CALLING_MODE sendPointPtr(const Point* point);
EXPORT void CALLING_MODE sendRectangle(const Rectangle rectangle);
EXPORT void CALLING_MODE sendRectangleRef(const Rectangle& rectangle);
EXPORT void CALLING_MODE sendRectanglePtr(const Rectangle* rectangle);
EXPORT Point* CALLING_MODE receivePoint();
EXPORT Rectangle* CALLING_MODE receiveRectangle();
EXPORT void CALLING_MODE disposePoint(const Point* pointer);
EXPORT void CALLING_MODE disposeRectangle(const Rectangle* pointer);
