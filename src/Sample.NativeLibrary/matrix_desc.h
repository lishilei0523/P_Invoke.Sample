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
		for (size_t i = 0; i < this->Rows; i++)
		{
			delete[] this->Matrix[i];
		}
		delete[] this->Matrix;
		std::cout << "C++ MatrixDesc������������" << std::endl;
	}

	float** Matrix;
	int Rows;
	int Cols;
};
