#pragma once
#include <string>

/// <summary>
/// 消息
/// </summary>
class Message
{
private:

	/// <summary>
	/// 标题
	/// </summary>
	std::string _title;

	/// <summary>
	/// 内容
	/// </summary>
	std::string _content;


public:

	/// <summary>
	/// 构造函数
	/// </summary>
	/// <param name="title">标题</param>
	/// <param name="content">内容</param>
	Message(const std::string& title, const std::string& content);

	/// <summary>
	/// 析构函数
	/// </summary>
	~Message();


public:

	/// <summary>
	/// 发送
	/// </summary>
	/// <param name="receiver">收件人</param>
	void send(const std::string& receiver);

	/// <summary>
	/// 设置标题
	/// </summary>
	/// <param name="title">标题</param>
	void setTitle(const std::string& title);

	/// <summary>
	/// 设置内容
	/// </summary>
	/// <param name="content">内容</param>
	void setContent(const std::string& content);

	/// <summary>
	/// 获取标题
	/// </summary>
	/// <returns>标题</returns>
	std::string getTitle() const;

	/// <summary>
	/// 获取内容
	/// </summary>
	/// <returns>内容</returns>
	std::string getContent() const;
};
