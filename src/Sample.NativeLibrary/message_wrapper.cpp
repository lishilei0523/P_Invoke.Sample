#include "message_wrapper.h"

Message* createMessage(const char* title, const char* content)
{
	Message* message = new Message(title, content);

	return message;
}

void send(Message* message, const char* receiver)
{
	message->send(receiver);
}

void setTitle(Message* message, const char* title)
{
	message->setTitle(title);
}

void setContent(Message* message, const char* content)
{
	message->setContent(content);
}

char* getTitle(const Message* message)
{
	const std::string& title = message->getTitle();

#ifdef _WIN32
	char* text = _strdup(title.c_str());
#elif __linux__
	char* text = (char*)title.c_str();
#endif

	return text;
}

char* getContent(const Message* message)
{
	const std::string& content = message->getContent();

#ifdef _WIN32
	char* text = _strdup(content.c_str());
#elif __linux__
	char* text = (char*)content.c_str();
#endif

	return text;
}

void dispose(const Message* message)
{
	delete message;
}
