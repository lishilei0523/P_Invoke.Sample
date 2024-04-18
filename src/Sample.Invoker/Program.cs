using Sample.Invoker.Declares;
using Sample.Invoker.Models;
using System;
using System.Runtime.InteropServices;
using Rectangle = Sample.Invoker.Models.Rectangle;

namespace Sample.Invoker
{
    class Program
    {
        static void Main()
        {
#if NET40_OR_GREATER
            Console.WriteLine("From .NET Framework");
            Console.WriteLine("--------------------------------");
#endif
#if NETCOREAPP3_1_OR_GREATER
            Console.WriteLine("From .NET Core");
            Console.WriteLine("--------------------------------");
#endif
            //TestSendPrimitives();
            //TestReceivePrimitives();
            //TestSendString();
            //TestReceiveString();
            //TestSendNumbers();
            //TestReceiveNumbers();
            //TestSendStrings();
            //TestSendStructs();
            //TestSendStruct();
            TestSendComplexStruct();
            //TestSendStructPtr();
            TestSendComplexStructPtr();
            //TestReceiveStruct();
            TestReceiveComplexStruct();
            //TestReceiveStructPtr();
            TestReceiveComplexStructPtr();
            //TestReceiveHandledExpcetion();
            //TestReceiveUnhandledExpcetion();

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
            {
                "床前明月光",
                "疑是地上霜",
                "举头望明月",
                "低头思故乡"
            };
            Platform.SendStrings(lines, lines.Length);
        }

        static void TestSendStructs()
        {
            Point point1 = new Point("Point1", 1, 1);
            Point point2 = new Point("Point2", 2, 2);
            Point point3 = new Point("Point3", 3, 3);
            Point point4 = new Point("Point4", 4, 4);
            point1.Titles = new[] { "Title: 1.1f", "Title: 1.2f" };
            point2.Titles = new[] { "Title: 2.1f", "Title: 2.2f" };
            point3.Titles = new[] { "Title: 3.1f", "Title: 3.2f" };
            point4.Titles = new[] { "Title: 4.1f", "Title: 4.2f" };
            point1.Angles = new[] { 1.1f, 1.2f };
            point2.Angles = new[] { 2.1f, 2.2f };
            point3.Angles = new[] { 3.1f, 3.2f };
            point4.Angles = new[] { 4.1f, 4.2f };
            Point[] points = { point1, point2, point3, point4 };

            Platform.SendPoints(points, points.Length);
        }

        static void TestSendStruct()
        {
            Point point = new Point("C# Point", 11, 22);
            point.Titles = new[] { "Title: 1.1f", "Title: 2.2f" };
            point.Angles = new[] { 1.1f, 2.2f };
            Platform.SendPoint(point);
        }

        static void TestSendComplexStruct()
        {
            Point point1 = new Point("C# Point Min", 11, 12);
            point1.Titles = new[] { "Title: 1.1f", "Title: 1.2f" };
            point1.Angles = new[] { 1.1f, 1.2f };
            Point point2 = new Point("C# Point Max", 21, 22);
            point2.Titles = new[] { "Title: 2.1f", "Title: 2.2f" };
            point2.Angles = new[] { 2.1f, 2.2f };
            Rectangle rectangle = new Rectangle(point1, point2);

            Platform.SendRectangle(rectangle);
        }

        static void TestSendStructPtr()
        {
            Point point = new Point("C# Point", 33, 44);
            point.Titles = new[] { "Title: 3.3f", "Title: 4.4f" };
            point.Angles = new[] { 3.3f, 4.4f };

            //转结构体指针
            IntPtr pointPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Point)));
            Marshal.StructureToPtr(point, pointPtr, false);

            //发送
            Platform.SendPointPtr(pointPtr);

            //释放资源
            Marshal.FreeHGlobal(pointPtr);
        }

        static void TestSendComplexStructPtr()
        {
            Point point1 = new Point("C# Point Min", 11, 12);
            point1.Titles = new[] { "Title: 1.1f", "Title: 1.2f" };
            point1.Angles = new[] { 1.1f, 1.2f };
            Point point2 = new Point("C# Point Max", 21, 22);
            point2.Titles = new[] { "Title: 2.1f", "Title: 2.2f" };
            point2.Angles = new[] { 2.1f, 2.2f };
            Rectangle rectangle = new Rectangle(point1, point2);

            //转结构体指针
            IntPtr rectanglePtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Rectangle)));
            Marshal.StructureToPtr(rectangle, rectanglePtr, false);

            //发送
            Platform.SendRectanglePtr(rectanglePtr);

            //释放资源
            Marshal.FreeHGlobal(rectanglePtr);
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

        static void TestReceiveComplexStruct()
        {
            Console.WriteLine("C# 接收嵌套结构体");

            IntPtr rectanglePtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Rectangle)));
            Platform.ReceiveRectangle(rectanglePtr);
            Rectangle rectangle = Marshal.PtrToStructure<Rectangle>(rectanglePtr);
            Point point1 = rectangle.Min;
            Point point2 = rectangle.Max;

            Console.WriteLine($"C# PointMin.Name: {point1.Name}");
            Console.WriteLine($"C# PointMin.X: {point1.X}");
            Console.WriteLine($"C# PointMin.Y: {point1.Y}");
            for (int i = 0; i < point1.Angles.Length; i++)
            {
                Console.WriteLine($"C# PointMin.Titles[{i}]: {point1.Titles[i]}");
                Console.WriteLine($"C# PointMin.Angles[{i}]: {point1.Angles[i]}");
            }
            Console.WriteLine($"C# PointMax.Name: {point2.Name}");
            Console.WriteLine($"C# PointMax.X: {point2.X}");
            Console.WriteLine($"C# PointMax.Y: {point2.Y}");
            for (int i = 0; i < point2.Angles.Length; i++)
            {
                Console.WriteLine($"C# PointMax.Titles[{i}]: {point2.Titles[i]}");
                Console.WriteLine($"C# PointMax.Angles[{i}]: {point2.Angles[i]}");
            }

            //释放资源
            Marshal.FreeHGlobal(rectanglePtr);

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

        static void TestReceiveComplexStructPtr()
        {
            Console.WriteLine("C# 接收嵌套结构体指针");

            IntPtr rectanglePtr = Platform.ReceiveRectanglePtr();
            Rectangle rectangle = Marshal.PtrToStructure<Rectangle>(rectanglePtr);
            Point point1 = rectangle.Min;
            Point point2 = rectangle.Max;

            Console.WriteLine($"C# PointMin.Name: {point1.Name}");
            Console.WriteLine($"C# PointMin.X: {point1.X}");
            Console.WriteLine($"C# PointMin.Y: {point1.Y}");
            for (int i = 0; i < point1.Angles.Length; i++)
            {
                Console.WriteLine($"C# PointMin.Titles[{i}]: {point1.Titles[i]}");
                Console.WriteLine($"C# PointMin.Angles[{i}]: {point1.Angles[i]}");
            }
            Console.WriteLine($"C# PointMax.Name: {point2.Name}");
            Console.WriteLine($"C# PointMax.X: {point2.X}");
            Console.WriteLine($"C# PointMax.Y: {point2.Y}");
            for (int i = 0; i < point2.Angles.Length; i++)
            {
                Console.WriteLine($"C# PointMax.Titles[{i}]: {point2.Titles[i]}");
                Console.WriteLine($"C# PointMax.Angles[{i}]: {point2.Angles[i]}");
            }

            //释放资源
            Platform.DisposeRectanglePtr(rectanglePtr);

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
