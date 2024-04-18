using Sample.Invoker.Declares;
using Sample.Invoker.Models;
using System;
using System.Runtime.InteropServices;

namespace Sample.Invoker
{
    class Program
    {
        static void Main()
        {
            //TODO 结构体数组数据封送
            //TODO 结构体嵌套数组数据封送
            //TODO 结构体嵌套结构体数据封送

            //TestSendPrimitives();
            //TestReceivePrimitives();
            //TestSendString();
            //TestReceiveString();
            //TestSendNumbers();
            //TestReceiveNumbers();
            //TestSendStrings();
            TestSendStruct();
            TestSendStructPtr();
            TestReceiveStruct();
            TestReceiveStructPtr();

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
            IntPtr textPtr = Platform.ReceiveString();
            string text = Marshal.PtrToStringAnsi(textPtr);
            Console.WriteLine($"C#: {text}");
        }

        static void TestSendNumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 10 };
            Platform.SendNumbers(numbers, numbers.Length);
        }

        static unsafe void TestReceiveNumbers()
        {
            IntPtr numbersPtr = Platform.ReceiveNumbers();
            int* pointer = (int*)numbersPtr.ToPointer();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(pointer[i]);
            }
            NativeMemory.Clear(pointer, sizeof(int) * 5);
        }

        static void TestSendStrings()
        {
            string[] lines =
            [
                "床前明月光",
                "疑是地上霜",
                "举头望明月",
                "低头思故乡"
            ];
            Platform.SendStrings(lines, lines.Length);
        }

        static void TestSendStruct()
        {
            Point point = new Point("C# Point", 11, 22);
            Platform.SendPoint(point);
        }

        static void TestSendStructPtr()
        {
            Point point = new Point("C# Point", 33, 44);

            //转结构体指针
            IntPtr pointPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Point)));
            Marshal.StructureToPtr(point, pointPtr, false);

            //发送
            Platform.SendPointPtr(pointPtr);

            //释放资源
            Marshal.FreeHGlobal(pointPtr);
        }

        static void TestReceiveStruct()
        {
            IntPtr pointPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Point)));
            Platform.ReceivePoint(pointPtr);
            Point point = Marshal.PtrToStructure<Point>(pointPtr);

            Console.WriteLine($"C# Point.Name: {point.Name}");
            Console.WriteLine($"C# Point.X: {point.X}");
            Console.WriteLine($"C# Point.Y: {point.Y}");

            //释放资源
            Marshal.FreeHGlobal(pointPtr);
        }

        static void TestReceiveStructPtr()
        {
            IntPtr pointPtr = Platform.ReceivePointPtr();
            Point point = Marshal.PtrToStructure<Point>(pointPtr);

            Console.WriteLine($"C# PointPtr.Name: {point.Name}");
            Console.WriteLine($"C# PointPtr.X: {point.X}");
            Console.WriteLine($"C# PointPtr.Y: {point.Y}");

            //释放资源
            Platform.DisposePointPtr(pointPtr);
        }
    }
}
