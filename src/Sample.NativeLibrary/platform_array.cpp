#include <iostream>
#include <format>
#include "platform_array.h"
using namespace std;

void sendNumbers(int numbers[], const int length)
{
	for (int i = 0; i < length; i++)
	{
		std::cout << numbers[i] << endl;
	}
}

void sendStrings(char* strings[], const int length)
{
	for (int i = 0; i < length; i++)
	{
		std::cout << strings[i] << endl;
	}
}

void sendPoints(Point points[], const int length)
{
	for (int i = 0; i < length; i++)
	{
		std::cout << "Point.Name: " << points[i].Name << endl;
		std::cout << "Point.X: " << points[i].X << endl;
		std::cout << "Point.Y: " << points[i].Y << endl;

		const Point point = points[i];
		for (int j = 0; j < 2; j++)
		{
			std::cout << std::format("C++ Point.Titles[{}]: {}", j, point.Titles[j]) << endl;
			std::cout << std::format("C++ Point.Angles[{}]: {}", j, point.Angles[j]) << endl;
		}
	}
}

ArrayDesc* receiveArray()
{
	constexpr int length = 10;
	int* numbers = new int[length];
	for (int i = 0; i < length; i++)
	{
		numbers[i] = i;
	}
	ArrayDesc* arrayDesc = new ArrayDesc(numbers, length);

	for (int i = 0; i < arrayDesc->Length; i++)
	{
		std::cout << std::format("C++ Array[{}]: {}", i, numbers[i]) << endl;
	}

	return arrayDesc;
}

RangeDesc* receiveRange()
{
	constexpr int length = 33;
	RangeDesc* rangeDesc = new RangeDesc();
	for (int i = 0; i < length; i++)
	{
		rangeDesc->Histogram[i] = static_cast<float>(i + 1);
	}
	for (int i = 0; i < length; i++)
	{
		std::cout << std::format("C++ Range[{}]: {}", i, rangeDesc->Histogram[i]) << endl;
	}

	return rangeDesc;
}

MatrixDesc* receiveMatrix()
{
	const int rows = 3;
	const int cols = 3;
	float** matrix = new float* [rows];
	for (int rowIndex = 0; rowIndex < rows; rowIndex++)
	{
		matrix[rowIndex] = new float[cols];
		for (int colIndex = 0; colIndex < cols; colIndex++)
		{
			matrix[rowIndex][colIndex] = static_cast<float>(rowIndex);
		}
	}

	for (int rowIndex = 0; rowIndex < rows; rowIndex++)
	{
		const float* row = matrix[rowIndex];
		for (int colIndex = 0; colIndex < cols; colIndex++)
		{
			std::cout << std::format("C++ Matrix[{}][{}]: {}", rowIndex, colIndex, row[colIndex]) << endl;
		}
	}

	MatrixDesc* matrixDesc = new MatrixDesc(matrix, rows, cols);

	return matrixDesc;
}

void disposeArray(const ArrayDesc* pointer)
{
	delete pointer;
}

void disposeRange(const RangeDesc* pointer)
{
	delete pointer;
}

void disposeMatrix(const MatrixDesc* pointer)
{
	delete pointer;
}
