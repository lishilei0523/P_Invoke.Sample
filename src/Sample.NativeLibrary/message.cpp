#include <iostream>
#include <format>
#include "message.h"
using namespace std;

/// <summary>
/// 构造函数
/// </summary>
/// <param name="title">标题</param>
/// <param name="content">内容</param>
Message::Message(const std::string& title, const std::string& content)
	:_title(title), _content(content)
{
	std::cout << "C++: message has created." << endl;
}

/// <summary>
/// 析构函数
/// </summary>
Message::~Message()
{
	std::cout << "C++: message has disposed." << endl;
}

/// <summary>
/// 发送
/// </summary>
/// <param name="receiver">收件人</param>
void Message::send(const std::string& receiver)
{
	std::cout << "---------------- From C++ ----------------" << endl;
	std::cout << std::format("标题: {}", this->_title) << endl;
	std::cout << std::format("内容: {}", this->_content) << endl;
	std::cout << std::format("已发送至 {}", receiver) << endl;
	std::cout << "---------------- End ----------------" << endl;
}

/// <summary>
/// 设置标题
/// </summary>
/// <param name="title">标题</param>
void Message::setTitle(const std::string& title)
{
	this->_title = title;
}

/// <summary>
/// 设置内容
/// </summary>
/// <param name="content">内容</param>
void Message::setContent(const std::string& content)
{
	this->_content = content;
}

/// <summary>
/// 获取标题
/// </summary>
/// <returns>标题</returns>
std::string Message::getTitle() const
{
	return this->_title;
}

/// <summary>
/// 获取内容
/// </summary>
/// <returns>内容</returns>
std::string Message::getContent() const
{
	return this->_content;
}
