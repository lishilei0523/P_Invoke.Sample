using System.Runtime.InteropServices;

namespace Sample.Invoker.Models
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Point
    {
        public int X;
        public int Y;
    }
}
