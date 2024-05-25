#pragma once
#include <iostream>

struct MatrixDesc
{
	MatrixDesc() = default;
	MatrixDesc(float** matrix, const int rows, const int cols)
	{
		this->Matrix = matrix;
		this->Rows = rows;
		this->Cols = cols;
	}
	~MatrixDesc()
	{
		for (int rowIndex = 0; rowIndex < this->Rows; rowIndex++)
		{
			delete[] this->Matrix[rowIndex];
		}
		delete[] this->Matrix;
		std::cout << "C++ MatrixDesc析构函数调用" << std::endl;
	}

	float** Matrix;
	int Rows;
	int Cols;
};
