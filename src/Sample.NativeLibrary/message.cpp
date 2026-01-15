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
	std::cout << "message has created" << endl;
}

/// <summary>
/// 析构函数
/// </summary>
Message::~Message()
{
	std::cout << "message has disposed" << endl;
}

/// <summary>
/// 发送
/// </summary>
/// <param name="receiver">收件人</param>
void Message::send(const std::string& receiver)
{
	std::cout << std::format("标题: {}, 内容: {} 已发送至 {}", this->_title, this->_content, receiver) << endl;
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
