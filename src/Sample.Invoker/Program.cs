﻿using Sample.Invoker.Declares;
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
    }
}
