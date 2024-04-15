using Sample.Invoker.Declares;
using System;
using System.Runtime.InteropServices;

namespace Sample.Invoker
{
    class Program
    {
        static void Main()
        {
            //TODO 基元类型数组数据封送
            //TODO 字符串数组数据封送
            //TODO 结构体数据封送
            //TODO 结构体数组数据封送
            //TODO 结构体嵌套数组数据封送
            //TODO 结构体嵌套结构体数据封送

            //TestSendPrimitives();
            //TestReceivePrimitives();
            //TestSendString();
            TestReceiveString();
            //TestReceiveStringViaPtr();
            //TestExchangeString();

            Console.ReadKey();
        }

        static void TestSendPrimitives()
        {
            Platform.SendBool(true);
            Platform.SendByte(byte.MaxValue);
            Platform.SendSByte(sbyte.MaxValue);
            Platform.SendShort(short.MaxValue);
            Platform.SendUShort(ushort.MaxValue);
            Platform.SendInt(int.MaxValue);
            Platform.SendUInt(uint.MaxValue);
            Platform.SendLong(long.MaxValue);
            Platform.SendULong(ulong.MaxValue);
            Platform.SendFloat(float.MaxValue);
            Platform.SendDouble(double.MaxValue);
        }

        static void TestReceivePrimitives()
        {
            Console.WriteLine($"接收bool: {Platform.ReceiveBool()}");
            Console.WriteLine($"接收byte: {Platform.ReceiveByte()}");
            Console.WriteLine($"接收sbyte: {Platform.ReceiveSByte()}");
            Console.WriteLine($"接收short: {Platform.ReceiveShort()}");
            Console.WriteLine($"接收ushort: {Platform.ReceiveUShort()}");
            Console.WriteLine($"接收int: {Platform.ReceiveInt()}");
            Console.WriteLine($"接收uint: {Platform.ReceiveUInt()}");
            Console.WriteLine($"接收long: {Platform.ReceiveLong()}");
            Console.WriteLine($"接收ulong: {Platform.ReceiveULong()}");
            Console.WriteLine($"接收float: {Platform.ReceiveFloat()}");
            Console.WriteLine($"接收double: {Platform.ReceiveDouble()}");
        }

        static void TestSendString()
        {
            Platform.SendString("Hello World");
        }

        static void TestReceiveString()
        {
            string text = Platform.ReceiveString();
            Console.WriteLine($"C#: {text}");
        }

        static void TestReceiveStringViaPtr()
        {
            IntPtr textPtr = Platform.ReceiveStringViaPtr();
            string text = Marshal.PtrToStringAnsi(textPtr);
            Console.WriteLine($"C#: {text}");
        }
    }
}
