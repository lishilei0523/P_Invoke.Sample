using System.Runtime.InteropServices;

namespace Sample.Invoker.Models
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct Rectangle
    {
        public Rectangle(Point min, Point max)
        {
            this.Min = min;
            this.Max = max;
        }

        public readonly Point Min;
        public readonly Point Max;
    }
}
