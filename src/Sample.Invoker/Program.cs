using Sample.Invoker.Declares;
using System;

namespace Sample.Invoker
{
    class Program
    {
        static void Main()
        {
            //TODO 基元类型：bool、int、long、float、double、byte类型数据封送
            //TODO 基元类型：string类型数据封送
            //TODO 基元类型数组数据封送
            //TODO 字符串数组数据封送
            //TODO 结构体数据封送
            //TODO 结构体数组数据封送
            //TODO 结构体嵌套数组数据封送
            //TODO 结构体嵌套结构体数据封送

            TestPlatform();

            Console.ReadKey();
        }

        static void TestPlatform()
        {
            int a = 25;
            int b = 10;
            int sum = Platform.Sum(a, b);
            int diff = Platform.Minus(a, b);
            int textLength = Platform.Greet("Hello World");

            Console.WriteLine(sum);
            Console.WriteLine(diff);
            Console.WriteLine(textLength);
        }
    }
}
