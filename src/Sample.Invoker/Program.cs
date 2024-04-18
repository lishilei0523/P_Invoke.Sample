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
            //TODO 结构体嵌套结构体数据封送

            //TestSendPrimitives();
            //TestReceivePrimitives();
            //TestSendString();
            //TestReceiveString();
            //TestSendNumbers();
            //TestReceiveNumbers();
            //TestSendStrings();
            //TestSendStructs();
            //TestSendStruct();
            //TestSendStructPtr();
            //TestReceiveStruct();
            //TestReceiveStructPtr();
            //TestReceiveHandledExpcetion();
            TestReceiveUnhandledExpcetion();

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

        static void TestSendStructs()
        {
            Point point1 = new Point("Point1", 1, 1);
            Point point2 = new Point("Point2", 2, 2);
            Point point3 = new Point("Point3", 3, 3);
            Point point4 = new Point("Point4", 4, 4);
            point1.Titles = ["Title: 1.1f", "Title: 1.2f"];
            point2.Titles = ["Title: 2.1f", "Title: 2.2f"];
            point3.Titles = ["Title: 3.1f", "Title: 3.2f"];
            point4.Titles = ["Title: 4.1f", "Title: 4.2f"];
            point1.Angles = [1.1f, 1.2f];
            point2.Angles = [2.1f, 2.2f];
            point3.Angles = [3.1f, 3.2f];
            point4.Angles = [4.1f, 4.2f];
            Point[] points = [point1, point2, point3, point4];

            Platform.SendPoints(points, points.Length);
        }

        static void TestSendStruct()
        {
            Point point = new Point("C# Point", 11, 22);
            point.Titles = ["Title: 1.1f", "Title: 2.2f"];
            point.Angles = [1.1f, 2.2f];
            Platform.SendPoint(point);
        }

        static void TestSendStructPtr()
        {
            Point point = new Point("C# Point", 33, 44);
            point.Titles = ["Title: 3.3f", "Title: 4.4f"];
            point.Angles = [3.3f, 4.4f];

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
            Console.WriteLine("C# 接收结构体");

            IntPtr pointPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Point)));
            Platform.ReceivePoint(pointPtr);
            Point point = Marshal.PtrToStructure<Point>(pointPtr);

            Console.WriteLine($"C# Point.Name: {point.Name}");
            Console.WriteLine($"C# Point.X: {point.X}");
            Console.WriteLine($"C# Point.Y: {point.Y}");
            for (int i = 0; i < point.Angles.Length; i++)
            {
                Console.WriteLine($"C# Point.Titles[{i}]: {point.Titles[i]}");
                Console.WriteLine($"C# Point.Angles[{i}]: {point.Angles[i]}");
            }

            //释放资源
            Marshal.FreeHGlobal(pointPtr);

            Console.WriteLine("------------------------------");
        }

        static void TestReceiveStructPtr()
        {
            Console.WriteLine("C# 接收结构体指针");

            IntPtr pointPtr = Platform.ReceivePointPtr();
            Point point = Marshal.PtrToStructure<Point>(pointPtr);

            Console.WriteLine($"C# PointPtr.Name: {point.Name}");
            Console.WriteLine($"C# PointPtr.X: {point.X}");
            Console.WriteLine($"C# PointPtr.Y: {point.Y}");
            for (int i = 0; i < point.Angles.Length; i++)
            {
                Console.WriteLine($"C# Point.Titles[{i}]: {point.Titles[i]}");
                Console.WriteLine($"C# Point.Angles[{i}]: {point.Angles[i]}");
            }

            //释放资源
            Platform.DisposePointPtr(pointPtr);

            Console.WriteLine("------------------------------");
        }

        static void TestReceiveHandledExpcetion()
        {
            try
            {
                Platform.ReceiveHandledExpcetion();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("异常");
            }
        }

        static void TestReceiveUnhandledExpcetion()
        {
            try
            {
                Platform.ReceiveUnhandledExpcetion();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("异常");
            }
        }
    }
}
