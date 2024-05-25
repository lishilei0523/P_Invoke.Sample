#include <iostream>
#include <format>
#include <vector>
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
			std::cout << "C++ Point.Titles[" << j << "]: " << point.Titles[j] << endl;
			std::cout << "C++ Point.Angles[" << j << "]: " << point.Angles[j] << endl;
		}
	}
}

ArrayDesc* receiveArray()
{
	vector<int> numbers;
	for (int i = 0; i < 10; i++)
	{
		numbers.push_back(i);
	}

	const int length = (int)numbers.size();
	int* numbersPtr = new int[length];
	memcpy(numbersPtr, numbers.data(), length * sizeof(int));
	ArrayDesc* arrayDesc = new ArrayDesc(numbersPtr, length);

	for (int i = 0; i < arrayDesc->Length; i++)
	{
		std::cout << "C++ Array[" << i << "]: " << numbersPtr[i] << endl;
	}

	return arrayDesc;
}

MatrixDesc* receiveMatrix()
{
	const int rows = 3;
	const int cols = 3;
	float** matrix = new float* [rows];
	for (int i = 0; i < rows; i++)
	{
		matrix[i] = new float[cols];
	}
	matrix[0][0] = 1;
	matrix[0][1] = 2;
	matrix[0][2] = 3;
	matrix[1][0] = 4;
	matrix[1][1] = 5;
	matrix[1][2] = 6;
	matrix[2][0] = 7;
	matrix[2][1] = 8;
	matrix[2][2] = 9;

	for (int rowIndex = 0; rowIndex < rows; rowIndex++)
	{
		const float* row = matrix[rowIndex];
		for (int colIndex = 0; colIndex < cols; colIndex++)
		{
			std::cout << std::format("C++ Matrix[{}][{}]: ", rowIndex, colIndex) << row[colIndex] << endl;
		}
	}

	MatrixDesc* matrixDesc = new MatrixDesc(matrix, rows, cols);

	return matrixDesc;
}

RangeDesc* receiveRange()
{
	RangeDesc* rangeDesc = new RangeDesc();
	for (int i = 0; i < 33; i++)
	{
		rangeDesc->Histogram[i] = static_cast<float>(i + 1);
	}
	for (int i = 0; i < 33; i++)
	{
		std::cout << std::format("C++ Range[{}]: ", i) << rangeDesc->Histogram[i] << endl;
	}

	return rangeDesc;
}

void disposeArray(const ArrayDesc* pointer)
{
	delete pointer;
}

void disposeMatrix(const MatrixDesc* pointer)
{
	delete pointer;
}

void disposeRange(const RangeDesc* pointer)
{
	delete pointer;
}
