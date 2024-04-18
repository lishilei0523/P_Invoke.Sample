using System.Runtime.InteropServices;

namespace Sample.Invoker.Models
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Rectangle
    {
        public Point Min;
        public Point Max;
    }
}
