#pragma once
#ifdef _WIN32
#define EXPORT_C extern "C" __declspec(dllexport)
#define CALLING_MODE _cdecl
#elif __linux__
#define EXPORT_C extern "C"
#define CALLING_MODE __attribute__((__cdecl__))
#endif
#include "point.h"
#include "rectangle.h"

EXPORT_C void CALLING_MODE sendPoint(const Point point);
EXPORT_C void CALLING_MODE sendPointRef(const Point& point);
EXPORT_C void CALLING_MODE sendPointPtr(const Point* point);
EXPORT_C void CALLING_MODE sendRectangle(const Rectangle rectangle);
EXPORT_C void CALLING_MODE sendRectangleRef(const Rectangle& rectangle);
EXPORT_C void CALLING_MODE sendRectanglePtr(const Rectangle* rectangle);
EXPORT_C Point* CALLING_MODE receivePoint();
EXPORT_C Rectangle* CALLING_MODE receiveRectangle();
EXPORT_C void CALLING_MODE disposePoint(const Point* pointer);
EXPORT_C void CALLING_MODE disposeRectangle(const Rectangle* pointer);
