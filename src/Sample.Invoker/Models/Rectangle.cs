using System.Runtime.InteropServices;

namespace Sample.Invoker.Models
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Rectangle
    {
        public Rectangle(Point min, Point max)
        {
            this.Min = min;
            this.Max = max;
        }

        public Point Min;
        public Point Max;
    }
}
