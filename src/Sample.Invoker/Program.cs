using Sample.Invoker.Declarations;
using Sample.Invoker.Models;
using System;
using System.Runtime.InteropServices;

namespace Sample.Invoker
{
    unsafe class Program
    {
        static void Main()
        {
#if NET40_OR_GREATER
            Console.WriteLine("From .NET Framework");
            Console.WriteLine("------------------------------------------------------------");
#endif
#if NETCOREAPP3_1_OR_GREATER
            Console.WriteLine("From .NET Core");
            Console.WriteLine("------------------------------------------------------------");
#endif
            //TestSendPrimitives();
            //TestReceivePrimitives();
            //TestSendString();
            //TestReceiveString();
            //TestSendNumbers();
            //TestSendStrings();
            //TestSendStructs();
            //TestReceiveArray();
            //TestReceiveRange();
            //TestReceiveMatrix();
            //TestSendStruct();
            //TestSendStructRef();
            //TestSendStructPtr();
            //TestSendComplexStruct();
            //TestSendComplexStructRef();
            //TestSendComplexStructPtr();
            //TestReceiveStruct();
            //TestReceiveComplexStruct();
            //TestReceiveHandledExpcetion();
            //TestReceiveUnhandledExpcetion();

            //while (true)
            //{
            //    Stopwatch stopwatch = new Stopwatch();
            //    stopwatch.Start();

            //    TestSendStructRef();

            //    stopwatch.Stop();
            //    Console.WriteLine(stopwatch.Elapsed);
            //    Thread.Sleep(500);
            //}

            Console.ReadKey();
        }

        static void TestSendPrimitives()
        {
            Platform.SendBool(true);
            Platform.SendByte(255);
            Platform.SendSByte(127);
            Platform.SendShort(32000);
            Platform.SendUShort(65500);
            Platform.SendInt(2165500);
            Platform.SendUInt(4165500);
            Platform.SendLong(84165500);
            Platform.SendULong(164165500);
            Platform.SendFloat(0.5f);
            Platform.SendDouble(3.14);
        }

        static void TestReceivePrimitives()
        {
            Console.WriteLine($"C#接收bool: {Platform.ReceiveBool()}");
            Console.WriteLine($"C#接收byte: {Platform.ReceiveByte()}");
            Console.WriteLine($"C#接收sbyte: {Platform.ReceiveSByte()}");
            Console.WriteLine($"C#接收short: {Platform.ReceiveShort()}");
            Console.WriteLine($"C#接收ushort: {Platform.ReceiveUShort()}");
            Console.WriteLine($"C#接收int: {Platform.ReceiveInt()}");
            Console.WriteLine($"C#接收uint: {Platform.ReceiveUInt()}");
            Console.WriteLine($"C#接收long: {Platform.ReceiveLong()}");
            Console.WriteLine($"C#接收ulong: {Platform.ReceiveULong()}");
            Console.WriteLine($"C#接收float: {Platform.ReceiveFloat()}");
            Console.WriteLine($"C#接收double: {Platform.ReceiveDouble()}");
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
                "AAAAAAAA",
                "BBBBBBBB",
                "CCCCCCCC",
                "低头思故乡"
            };
            Platform.SendStrings(lines, lines.Length);
        }

        static void TestSendStructs()
        {
            string[] point1Titles = { "Title: 1.1f", "Title: 1.2f" };
            string[] point2Titles = { "Title: 2.1f", "Title: 2.2f" };
            string[] point3Titles = { "Title: 3.1f", "Title: 3.2f" };
            string[] point4Titles = { "Title: 4.1f", "Title: 4.2f" };
            float[] point1Angles = { 1.1f, 1.2f };
            float[] point2Angles = { 2.1f, 2.2f };
            float[] point3Angles = { 3.1f, 3.2f };
            float[] point4Angles = { 4.1f, 4.2f };
            Point point1 = new Point("Point1", 1, 1, point1Titles, point1Angles);
            Point point2 = new Point("Point2", 2, 2, point2Titles, point2Angles);
            Point point3 = new Point("Point3", 3, 3, point3Titles, point3Angles);
            Point point4 = new Point("Point4", 4, 4, point4Titles, point4Angles);

            Point[] points = { point1, point2, point3, point4 };

            Platform.SendPoints(points, points.Length);
        }

        static void TestReceiveArray()
        {
            Console.WriteLine("C# 接收数组");

            IntPtr pointer = Platform.ReceiveArray();
            ArrayDesc arrayDesc = Marshal.PtrToStructure<ArrayDesc>(pointer);

            Span<int> span = new Span<int>(arrayDesc.Numbers.ToPointer(), arrayDesc.Length);
            for (int i = 0; i < span.Length; i++)
            {
                Console.WriteLine($"C# Array[{i}]: {span[i]}");
            }

            //释放资源
            Platform.DisposeArray(pointer);

            Console.WriteLine("------------------------------------------------------------");
        }

        static void TestReceiveRange()
        {
            Console.WriteLine("C# 接收序列");

            IntPtr pointer = Platform.ReceiveRange();
            RangeDesc rangeDesc = Marshal.PtrToStructure<RangeDesc>(pointer);
            for (int i = 0; i < rangeDesc.Histogram.Length; i++)
            {
                Console.WriteLine($"C# Range[{i}]: {rangeDesc.Histogram[i]}");
            }

            //释放资源
            Platform.DisposeRange(pointer);

            Console.WriteLine("------------------------------------------------------------");
        }

        static void TestReceiveMatrix()
        {
            Console.WriteLine("C# 接收矩阵");

            IntPtr pointer = Platform.ReceiveMatrix();
            MatrixDesc matrixDesc = Marshal.PtrToStructure<MatrixDesc>(pointer);

            double[,] matrix = new double[matrixDesc.Rows, matrixDesc.Cols];
            Span<IntPtr> span = new Span<IntPtr>(matrixDesc.Matrix.ToPointer(), matrixDesc.Rows);
            for (int rowIndex = 0; rowIndex < matrixDesc.Rows; rowIndex++)
            {
                IntPtr rowPtr = span[rowIndex];
                Span<float> row = new Span<float>(rowPtr.ToPointer(), matrixDesc.Cols);
                for (int colIndex = 0; colIndex < matrixDesc.Cols; colIndex++)
                {
                    matrix[rowIndex, colIndex] = row[colIndex];
                    Console.WriteLine($"C# Matrix[{rowIndex}][{colIndex}]: {row[colIndex]}");
                }
            }

            //释放资源
            Platform.DisposeMatrix(pointer);

            Console.WriteLine("------------------------------------------------------------");
        }

        static void TestSendStruct()
        {
            string[] titles = { "Title: 1.1f", "Title: 1.2f" };
            float[] angles = { 1.1f, 1.2f };
            Point point = new Point("C# Point", 11, 12, titles, angles);

            int addr = (int)&point;
            Console.WriteLine($"Point.Addr: {addr:X16} from C#");

            Platform.SendPoint(point);
        }

        static void TestSendStructRef()
        {
            string[] titles = { "Title: 2.1f", "Title: 2.2f" };
            float[] angles = { 2.1f, 2.2f };
            Point point = new Point("C# Point", 21, 22, titles, angles);

            int addr = (int)&point;
            Console.WriteLine($"Point.Addr: {addr:X16} from C#");

            Platform.SendPointRef(ref point);
        }

        static void TestSendStructPtr()
        {
            string[] titles = { "Title: 3.1f", "Title: 3.2f" };
            float[] angles = { 3.1f, 3.2f };
            Point point = new Point("C# Point", 31, 32, titles, angles);

            //转结构体指针
            IntPtr pointPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Point)));
            Marshal.StructureToPtr(point, pointPtr, false);

            int addr = (int)pointPtr.ToPointer();
            Console.WriteLine($"Point.Addr: {addr:X16} from C#");

            //发送
            Platform.SendPointPtr(pointPtr);

            //释放资源
            Marshal.FreeHGlobal(pointPtr);
        }

        static void TestSendComplexStruct()
        {
            string[] titles1 = { "Title: 1.1f", "Title: 1.2f" };
            string[] titles2 = { "Title: 2.1f", "Title: 2.2f" };
            float[] angles1 = { 1.1f, 1.2f };
            float[] angles2 = { 2.1f, 2.2f };
            Point point1 = new Point("C# Point Min", 11, 12, titles1, angles1);
            Point point2 = new Point("C# Point Max", 21, 22, titles2, angles2);
            Rectangle rectangle = new Rectangle(point1, point2);

            int addr = (int)&rectangle;
            Console.WriteLine($"Rectangle.Addr: {addr:X16} from C#");

            Platform.SendRectangle(rectangle);
        }

        static void TestSendComplexStructRef()
        {
            string[] titles1 = { "Title: 1.1f", "Title: 1.2f" };
            string[] titles2 = { "Title: 2.1f", "Title: 2.2f" };
            float[] angles1 = { 1.1f, 1.2f };
            float[] angles2 = { 2.1f, 2.2f };
            Point point1 = new Point("C# Point Min", 11, 12, titles1, angles1);
            Point point2 = new Point("C# Point Max", 21, 22, titles2, angles2);
            Rectangle rectangle = new Rectangle(point1, point2);

            int addr = (int)&rectangle;
            Console.WriteLine($"Rectangle.Addr: {addr:X16} from C#");

            Platform.SendRectangleRef(ref rectangle);
        }

        static void TestSendComplexStructPtr()
        {
            string[] titles1 = { "Title: 1.1f", "Title: 1.2f" };
            string[] titles2 = { "Title: 2.1f", "Title: 2.2f" };
            float[] angles1 = { 1.1f, 1.2f };
            float[] angles2 = { 2.1f, 2.2f };
            Point point1 = new Point("C# Point Min", 11, 12, titles1, angles1);
            Point point2 = new Point("C# Point Max", 21, 22, titles2, angles2);
            Rectangle rectangle = new Rectangle(point1, point2);

            //转结构体指针
            IntPtr rectanglePtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Rectangle)));
            Marshal.StructureToPtr(rectangle, rectanglePtr, false);

            int addr = (int)rectanglePtr.ToPointer();
            Console.WriteLine($"Rectangle.Addr: {addr:X16} from C#");

            //发送
            Platform.SendRectanglePtr(rectanglePtr);

            //释放资源
            Marshal.FreeHGlobal(rectanglePtr);
        }

        static void TestReceiveStruct()
        {
            Console.WriteLine("C# 接收结构体");

            IntPtr pointPtr = Platform.ReceivePoint();
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
            Platform.DisposePoint(pointPtr);

            Console.WriteLine("------------------------------------------------------------");
        }

        static void TestReceiveComplexStruct()
        {
            Console.WriteLine("C# 接收嵌套结构体");

            IntPtr rectanglePtr = Platform.ReceiveRectangle();
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
            Platform.DisposeRectangle(rectanglePtr);

            Console.WriteLine("------------------------------------------------------------");
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
