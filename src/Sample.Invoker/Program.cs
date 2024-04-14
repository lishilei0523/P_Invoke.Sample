using Sample.Invoker.Declares;
using System;

namespace Sample.Invoker
{
    class Program
    {
        static void Main()
        {
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
