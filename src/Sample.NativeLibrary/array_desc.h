#pragma once

struct ArrayDesc
{
	ArrayDesc();
	ArrayDesc(const int* numbers, const int length);
	~ArrayDesc();

	const int* Numbers;
	int Length;
};
